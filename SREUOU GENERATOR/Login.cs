using Siticone.UI.WinForms;
using SREUOU_GENERATOR.Properties;
using System;
using KeyAuth;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace SREUOU_GENERATOR
{
    public partial class Login : Form
    {
        public static api KeyAuthApp = new api(
        name: ",",
        ownerid: "JBtzIhGeN8",
        secret: "18a3b0324291e281fa0a09f09141eb1273cb773b7c4d95302ea2840caea43541",
        version: "1.0"
        );
        Point lastPoint;
        public Login()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            try
            {
                const int RESIZE_HANDLE_SIZE = 10;
                switch (m.Msg)
                {
                    case 0x0084/*NCHITTEST*/ :
                        base.WndProc(ref m);

                        if ((int)m.Result == 0x01/*HTCLIENT*/)
                        {
                            Point screenPoint = new Point(m.LParam.ToInt32());
                            Point clientPoint = this.PointToClient(screenPoint);
                            if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                            {
                                if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                {
                                    m.Result = (IntPtr)13/*HTTOPLEFT*/ ;
                                }
                                else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                {
                                    m.Result = (IntPtr)12/*HTTOP*/ ;
                                }
                                else
                                {
                                    m.Result = (IntPtr)14/*HTTOPRIGHT*/ ;
                                }
                            }
                            else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                            {
                                Thread.Sleep(10);
                                if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                {
                                    m.Result = (IntPtr)10/*HTLEFT*/ ;
                                }
                                else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                {
                                    m.Result = (IntPtr)2/*HTCAPTION*/ ;
                                }
                                else
                                {
                                    m.Result = (IntPtr)11/*HTRIGHT*/ ;
                                }
                            }
                            else
                            {
                                if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                {
                                    m.Result = (IntPtr)16;
                                }
                                else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                {
                                    m.Result = (IntPtr)15;
                                }
                                else
                                {
                                    m.Result = (IntPtr)17;
                                }
                            }
                        }
                        return;
                }
                base.WndProc(ref m);
            }
            catch { }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000;
                return cp;
            }
        }

        public static bool SubExist(string name)
        {
            if (KeyAuthApp.user_data.subscriptions.Exists(x => x.subscription == name))
                return true;
            return false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();

            if (KeyAuthApp.response.message == "invalidver")
            {
                if (!string.IsNullOrEmpty(KeyAuthApp.app_data.downloadLink))
                {
                    DialogResult dialogResult = MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", MessageBoxButtons.YesNo);
                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            Process.Start(KeyAuthApp.app_data.downloadLink);
                            Environment.Exit(0);
                            break;
                        case DialogResult.No:
                            WebClient webClient = new WebClient();
                            string destFile = Application.ExecutablePath;

                            string rand = random_string();

                            destFile = destFile.Replace(".exe", $"-{rand}.exe");
                            webClient.DownloadFile(KeyAuthApp.app_data.downloadLink, destFile);

                            Process.Start(destFile);
                            Process.Start(new ProcessStartInfo()
                            {
                                Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                                WindowStyle = ProcessWindowStyle.Hidden,
                                CreateNoWindow = true,
                                FileName = "cmd.exe"
                            });
                            Environment.Exit(0);

                            break;
                        default:
                            MessageBox.Show("Invalid option");
                            Environment.Exit(0);
                            break;
                    }
                }
                MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer");
                Environment.Exit(0);
            }
        }

        static string random_string()
        {
            string str = null;

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
            }
            return str;

        }

        public string Hide()
        {
            string text = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm1234567890";
            string text2 = "";
            Random random = new Random();
            int num = random.Next(5, text.Length);
            for (int i = 0; i < num; i++)
            {
                text2 += text[random.Next(0, text.Length)];
            }
            return text2;
        }


        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void siticoneToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void siticoneButton21_Click(object sender, EventArgs e)
        {
            Settings1.Default.timer = "true";
            MessageBox.Show("THIS IS DEMO SREUOU PROJECT GENERATOR", "SREUOU PROJECT GENENEGATOR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Form1 main = new Form1();
            main.Show();
            base.Hide();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            this.Name = Hide().ToString();
            this.Text = Hide().ToString();
        }
    }
}