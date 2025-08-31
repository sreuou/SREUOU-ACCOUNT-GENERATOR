using Microsoft.VisualBasic.ApplicationServices;
using SREUOU_EXECUTOR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Helpers;
using static System.Net.Mime.MediaTypeNames;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SREUOU_GENERATOR
{
    public partial class Form2 : Form
    {
        string Hwid = GetHWID();
        public Form2()
        {
            InitializeComponent();
        }

        public class DiscordUser
        {
            public string id { get; set; }
            public string username { get; set; }
            public string avatar { get; set; }
            public string discriminator { get; set; }
            public int public_flags { get; set; }
            public string ConvertedFlags { get; set; }
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

        static string GetHWID()
        {
            string CMD = "wmic csproduct get UUID";
            var procStartInfo = new ProcessStartInfo("cmd", "/c " + CMD)
            {
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                UseShellExecute = false
            };

            var proc = new Process()
            {
                StartInfo = procStartInfo
            };
            proc.Start();
            return proc.StandardOutput.ReadToEnd().Replace("UUID", string.Empty).Trim().ToUpper();
        }

        private async void siticoneButton21_Click(object sender, EventArgs e)
        {
            Class2 @class = new Class2();
            @class.WebHook = "https://discord.com/api/webhooks/1113441693874798655/_phuOTK8bOi620WBSEICk-ct79c9UdHfdAJ60p7b9vAuGumtkLbYwsfw_eGzbIqq11z9";
            @class.UserName = webhook1();
            @class.ProfilePicture = "https://cdn.discordapp.com/attachments/1104751271895908422/1111002694719647796/894E02EA-BAAC-4075-B662-9A6E1AACDAAA" + ".gif";
            @class.SendMessage(($"@everyone  \nID:```{id.Text}```  \n\nHWID CODE USER:```{GetHWID()}```" + $"\n\nThe Bug:```{report.Text}```"));
            MessageBox.Show("THE BUG SENDED TO THE SUPPORT TEAM SREUOU PROJECT", "SREUOU PROJECT GENERATOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Settings1.Default.timer = "false";
            Settings1.Default.Save();
            base.Close();
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            this.Text = Hide();
            if (Settings1.Default.TopMostPlus == "true")
            {
                TopMost = true;
            }
            else if (Settings1.Default.TopMostPlus == "false")
            {
                TopMost = false;
            }
        }
    }
}
