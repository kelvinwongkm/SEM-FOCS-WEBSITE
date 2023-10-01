using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;

namespace SEAM_Assignment
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //lblUserIP.Text = GetUserIP();
            lblUserIP.Text = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList.GetValue(0).ToString();

            lblUserIP.Text = GetIp();

            string ip = GetUserIP();
            lblUserIP.Text = GetIP4Address(ip);

        }
        private string GetUserIP()
        {
            string ipList = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(ipList))
            {
                return ipList.Split(',')[0];
            }

            return Request.ServerVariables["REMOTE_ADDR"];
        }

        public static string GetIP4Address(string ip)
        {
            try
            {
                var hostNames = Dns.GetHostEntry(ip);
                var ipv4 = hostNames.AddressList.FirstOrDefault(a => a.AddressFamily == AddressFamily.InterNetwork);
                if (ipv4 != null)
                {
                    return ipv4.ToString();
                }

            }
            catch (Exception ex)
            {
                //log.WarnFormat("Error When Getting Client Ipv4");
            }

            return ip;
        }

        public static string GetIp()
        {
            var Request = HttpContext.Current.Request;

            try
            {

                Console.WriteLine(string.Join("|", new List<object> {
                    Request.UserHostAddress,
                    Request.Headers["X-Forwarded-For"],
                    Request.Headers["REMOTE_ADDR"]
                })
                );

                var ip = Request.UserHostAddress;
                if (Request.Headers["X-Forwarded-For"] != null)
                {
                    ip = Request.Headers["X-Forwarded-For"];
                    Console.WriteLine(ip + "|X-Forwarded-For");
                }
                else if (Request.Headers["REMOTE_ADDR"] != null)
                {
                    ip = Request.Headers["REMOTE_ADDR"];
                    Console.WriteLine(ip + "|REMOTE_ADDR");
                }
                return ip;
            }
            catch (Exception ex)
            {
                //Log.WriteInfo("Message :" + ex.Message + "<br/>" + Environment.NewLine +
                //    "StackTrace :" + ex.StackTrace);
            }
            return null;
        }

    }
}