using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;
using AForge.Imaging.Filters;
using System.Drawing.Imaging;

namespace MultiFaceRec
{
    public partial class main2 : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private int objectCount = 0;

        public main2()
        {
            InitializeComponent();
            InitializeWebcams();
        }

        private void InitializeWebcams()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in videoDevices)
            {
                cboWebcams.Items.Add(device.Name);
            }

            if (cboWebcams.Items.Count > 0)
            {
                cboWebcams.SelectedIndex = 0;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (videoDevices != null && videoDevices.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[cboWebcams.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                videoSource.Start();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();

                // Clear the PictureBox
                pictureBox.Image = null;
            }
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);

            // Apply image processing to detect objects
            int count = CountObjects(bitmap);

            // Display the result
            UpdateObjectCount(count);
            pictureBox.Image = bitmap;

            // Display CPU and RAM usage
            DisplayPerformanceInfo();
        }

        private int CountObjects(Bitmap bitmap)
        {
            // Implement object detection here
            return 0; // Placeholder
        }

        private void UpdateObjectCount(int count)
        {
            // Update the object count label
            lblObjectCount.Invoke((MethodInvoker)delegate {
                lblObjectCount.Text = "Object Count: " + count.ToString();
            });
        }

        private void DisplayPerformanceInfo()
        {
            // Get CPU usage percentage
            float cpuUsage = GetCPUUsage();
            lblCPU.Invoke((MethodInvoker)delegate {
                lblCPU.Text = "CPU Usage: " + cpuUsage.ToString("0.00") + "%";
            });

            // Get RAM usage percentage
            float ramUsage = GetRAMUsage();
            lblRAM.Invoke((MethodInvoker)delegate {
                lblRAM.Text = "RAM Usage: " + ramUsage.ToString("0.00") + "%";
            });
        }

        private float GetCPUUsage()
        {
            PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            cpuCounter.NextValue(); // Call this first to get the initial value
            System.Threading.Thread.Sleep(500); // Wait a short moment for the value to be updated
            return cpuCounter.NextValue();
        }

        private float GetRAMUsage()
        {
            PerformanceCounter ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
            return ramCounter.NextValue();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }
    }
}
