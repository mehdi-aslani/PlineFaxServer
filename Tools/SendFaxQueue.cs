using System;
using System.Net.Http;
using System.Timers;
using PlineFaxServer.Controllers;
using PlineFaxServer.Data;

namespace PlineFaxServer.Tools
{
    public class SendFaxQueue
    {
        private Timer _timer;

        public SendFaxQueue()
        {
        }

        public void StartQueue()
        {
            _timer = new Timer() {Interval = 10000};
            _timer.Elapsed += TimerOnElapsed;
            _timer.Enabled = true;
            _timer.Start();
        }

        private void TimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            string strCmdText= "777 -R /opt/PlineFaxServer/wwwroot/FaxFiles/";
            System.Diagnostics.Process.Start("/usr/bin/chmod",strCmdText);
            
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), "http://localhost:5000/SendFax/SendFaxQueue"))
                {
                    var response = httpClient.Send(request);
                    Console.WriteLine("Sent...");
                }
            }
        }
    }
}