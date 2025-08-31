using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace SREUOU_EXECUTOR
{
    internal class Class1
    {
            public string WebHook { get; set; }
            public string UserName { get; set; }
            public string ProfilePicture { get; set; }

            public Class1()
            {
                dWebClient = new WebClient();
            }

            public void SendMessage(string msg)
            {
                discordValues.Add("username", UserName);
                discordValues.Add("avatar_url", ProfilePicture);
                discordValues.Add("content", msg);
                dWebClient.UploadValues(WebHook, discordValues);
            }

            public void Dispose()
            {
                dWebClient.Dispose();
            }

            private readonly WebClient dWebClient;

            private static NameValueCollection discordValues = new NameValueCollection();
        }
    }