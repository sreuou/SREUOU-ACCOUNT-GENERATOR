using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Net;

namespace SREUOU_GENERATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            Settings1.Default.webhooklink = webhook.Text;
            this.Name = Hide().ToString();
            this.Text = Hide().ToString();
            if (Settings1.Default.WebHook1 == "true")
            {
                siticoneToggleSwitch1.Checked = true;
            }
            if (Settings1.Default.TopMost == "true")
            {
                siticoneToggleSwitch3.Checked = true;
            }
            if (Settings1.Default.WebHook == "true")
            {
                siticoneToggleSwitch2.Checked = true;
            }        
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

        public string CreditCard()
        {
            string text = "1234567890";
            string text2 = "";
            Random random = new Random();
            int num = random.Next(5, text.Length);
            for (int i = 0; i < num; i++)
            {
                text2 += text[random.Next(0, text.Length)];
            }
            return text2;
        }

        public string webhook1()
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

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("COMING SOON...!", "SREUOU PROJECT GENENEGATOR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private async void siticoneButton3_Click(object sender, EventArgs e)
        {
            this.Opacity = 1000;
            await Task.Delay(50);
            this.Opacity = .800;
            await Task.Delay(50);
            this.Opacity = .700;
            await Task.Delay(50);
            this.Opacity = .600;
            await Task.Delay(50);
            this.Opacity = .500;
            await Task.Delay(50);
            this.Opacity = .400;
            await Task.Delay(50);
            this.Opacity = .300;
            await Task.Delay(50);
            this.Opacity = .200;
            await Task.Delay(50);
            this.Opacity = .100;
            await Task.Delay(50);
            this.Opacity = .0;
            await Task.Delay(100);
            Application.Exit();
        }

        private void siticoneButton19_Click(object sender, EventArgs e)
        {
            if (siticoneToggleSwitch1.Checked == true)
            {
                Class1 @class = new Class1();
                @class.WebHook = webhook.Text;
                @class.UserName = webhook1();
                @class.SendMessage("```No Stock!```");
                stock.PlaceholderText = "Lock Ur Server!";
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (siticoneToggleSwitch1.Checked == false)
            {
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siticoneButton15_Click(object sender, EventArgs e)
        {
            if (siticoneToggleSwitch1.Checked == true)
            {
                Class1 @class = new Class1();
                @class.WebHook = webhook.Text;
                @class.UserName = webhook1();
                @class.SendMessage("```No Stock!```");
                stock.PlaceholderText = "Lock Ur Server!";
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (siticoneToggleSwitch1.Checked == false)
            {
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            if (siticoneToggleSwitch1.Checked == true)
            {
                Class1 @class = new Class1();
                @class.WebHook = webhook.Text;
                @class.UserName = webhook1();
                @class.SendMessage("```No Stock!```");
                stock.PlaceholderText = "Lock Ur Server!";
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (siticoneToggleSwitch1.Checked == false)
            {
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            if (siticoneToggleSwitch1.Checked == true)
            {
                Class1 @class = new Class1();
                @class.WebHook = webhook.Text;
                @class.UserName = webhook1();
                @class.SendMessage("```No Stock!```");
                stock.PlaceholderText = "Lock Ur Server!";
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (siticoneToggleSwitch1.Checked == false)
            {
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            if (siticoneToggleSwitch1.Checked == true)
            {
                Class1 @class = new Class1();
                @class.WebHook = webhook.Text;
                @class.UserName = webhook1();
                @class.SendMessage("```No Stock!```");
                stock.PlaceholderText = "Lock Ur Server!";
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (siticoneToggleSwitch1.Checked == false)
            {
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            if (siticoneToggleSwitch1.Checked == true)
            {
                Class1 @class = new Class1();
                @class.WebHook = webhook.Text;
                @class.UserName = webhook1();
                @class.SendMessage("```No Stock!```");
                stock.PlaceholderText = "Lock Ur Server!";
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (siticoneToggleSwitch1.Checked == false)
            {
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siticoneButton10_Click(object sender, EventArgs e)
        {
            if (siticoneToggleSwitch1.Checked == true)
            {
                Class1 @class = new Class1();
                @class.WebHook = webhook.Text;
                @class.UserName = webhook1();
                @class.SendMessage("```No Stock!```");
                stock.PlaceholderText = "Lock Ur Server!";
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (siticoneToggleSwitch1.Checked == false)
            {
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            if (siticoneToggleSwitch1.Checked == true)
            {
                Class1 @class = new Class1();
                @class.WebHook = webhook.Text;
                @class.UserName = webhook1();
                @class.SendMessage("```No Stock!```");
                stock.PlaceholderText = "Lock Ur Server!";
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (siticoneToggleSwitch1.Checked == false)
            {
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siticoneButton21_Click(object sender, EventArgs e)
        {
            string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
            using (StreamWriter writer = new StreamWriter(tempFilename))
            {
                writer.WriteLine(@"echo off");
                writer.WriteLine(@"set browser=chrome.exe");
                writer.WriteLine(@"start %browser% -new-tab https://discord.gg/HPDqE9ZdEB");
            }
            Process process = Process.Start(tempFilename);
            process.WaitForExit();
            File.Delete(tempFilename);
        }

        private async void siticoneButton16_Click(object sender, EventArgs e)
        {
            if (siticoneToggleSwitch1.Checked == true)
            {
                await Task.Delay(5000);
                Random random2 = new Random();
                Class1 @class = new Class1();
                @class.WebHook = webhook.Text;
                @class.UserName = webhook1();
                @class.SendMessage($"```5538902{(Convert.ToString(random2.Next(100000000, 999999999)))}|0{(Convert.ToString(random2.Next(1, 9)))}|20{(Convert.ToString(random2.Next(24, 29)))}|{(Convert.ToString(random2.Next(100, 999)))}```");
                stock.PlaceholderText = "Lock Ur Server!";
                MessageBox.Show("Credit Card Successfully Generated!", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (siticoneToggleSwitch1.Checked == false)
            {
                Random random = new Random();
                stock.Text = $"5538902{(Convert.ToString(random.Next(100000000, 999999999)))}|0{(Convert.ToString(random.Next(1, 9)))}|20{(Convert.ToString(random.Next(24, 29)))}|{(Convert.ToString(random.Next(100, 999)))}";
                MessageBox.Show("Credit Card Successfully Generated!", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            if (siticoneToggleSwitch1.Checked == true)
            {
                Class1 @class = new Class1();
                @class.WebHook = webhook.Text;
                @class.UserName = webhook1();
                @class.SendMessage("```No Stock!```");
                stock.PlaceholderText = "Lock Ur Server!";
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (siticoneToggleSwitch1.Checked == false)
            {
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siticoneButton11_Click(object sender, EventArgs e)
        {
            if (siticoneToggleSwitch1.Checked == true)
            {
                Class1 @class = new Class1();
                @class.WebHook = webhook.Text;
                @class.UserName = webhook1();
                @class.SendMessage("```No Stock!```");
                stock.PlaceholderText = "Lock Ur Server!";
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (siticoneToggleSwitch1.Checked == false)
            {
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siticoneButton12_Click(object sender, EventArgs e)
        {
            if (siticoneToggleSwitch1.Checked == true)
            {
                Class1 @class = new Class1();
                @class.WebHook = webhook.Text;
                @class.UserName = webhook1();
                @class.SendMessage("```No Stock!```");
                stock.PlaceholderText = "Lock Ur Server!";
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (siticoneToggleSwitch1.Checked == false)
            {
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siticoneButton13_Click(object sender, EventArgs e)
        {
            if (siticoneToggleSwitch1.Checked == true)
            {
                Class1 @class = new Class1();
                @class.WebHook = webhook.Text;
                @class.UserName = webhook1();
                @class.SendMessage("```No Stock!```");
                stock.PlaceholderText = "Lock Ur Server!";
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (siticoneToggleSwitch1.Checked == false)
            {
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siticoneButton14_Click(object sender, EventArgs e)
        {
            if (siticoneToggleSwitch1.Checked == true)
            {
                Class1 @class = new Class1();
                @class.WebHook = webhook.Text;
                @class.UserName = webhook1();
                @class.SendMessage("```No Stock!```");
                stock.PlaceholderText = "Lock Ur Server!";
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (siticoneToggleSwitch1.Checked == false)
            {
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siticoneButton17_Click(object sender, EventArgs e)
        {
            if (siticoneToggleSwitch1.Checked == true)
            {
                Class1 @class = new Class1();
                @class.WebHook = webhook.Text;
                @class.UserName = webhook1();
                @class.SendMessage("```No Stock!```");
                stock.PlaceholderText = "Lock Ur Server!";
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (siticoneToggleSwitch1.Checked == false)
            {
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siticoneButton18_Click(object sender, EventArgs e)
        {
            if (siticoneToggleSwitch1.Checked == true)
            {
                Class1 @class = new Class1();
                @class.WebHook = webhook.Text;
                @class.UserName = webhook1();
                @class.SendMessage("```No Stock!```");
                stock.PlaceholderText = "Lock Ur Server!";
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (siticoneToggleSwitch1.Checked == false)
            {
                MessageBox.Show("No Stock", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siticoneToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneToggleSwitch1.Checked == true)
            {
                Settings1.Default.WebHook1 = "true";
                MessageBox.Show("The WebHook Is Working!", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (siticoneToggleSwitch1.Checked == false)
            {
                Settings1.Default.WebHook1 = "false";
                Settings1.Default.webhooklink = "";
                MessageBox.Show("The WebHook Is Off!", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siticoneToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {    
            if (siticoneToggleSwitch2.Checked == true)
            {
                Settings1.Default.WebHook = "true";
                Settings1.Default.Save();
                webhook.Visible = true;
                siticoneToggleSwitch1.Visible = true;
            }
            if (siticoneToggleSwitch2.Checked == false)
            {
                Settings1.Default.WebHook = "false";
                Settings1.Default.Save();
                webhook.Visible = false;
                siticoneToggleSwitch1.Visible = false;
            }
        }

        private void siticoneToggleSwitch3_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneToggleSwitch3.Checked == true)
            {
                Settings1.Default.TopMost = "true";
                Settings1.Default.TopMostPlus = "true";
                Settings1.Default.Save();
                TopMost = true;
            }
            if (siticoneToggleSwitch3.Checked == false)
            {
                Settings1.Default.TopMost = "false";
                Settings1.Default.TopMostPlus = "false";
                Settings1.Default.Save();
                TopMost = false;
            }
        }

        private void siticoneButton20_Click(object sender, EventArgs e)
        {
            if (Settings1.Default.timer == "true")
            {
                Form2 main = new Form2();
                main.Show();
            }
            else if (Settings1.Default.timer == "false")
            {
                timer1.Start();
                MessageBox.Show("PLEASE WAIT 5 MINS TO RESEND NEW BUG", "SREUOU PROJECT GENERATOR ANTI SPAM SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Settings1.Default.timer = "true";
            Settings1.Default.Save();
            timer1.Stop();
        }
    }
}