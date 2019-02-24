using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TriggerWebjob
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://webappname.scm.azurewebsites.net/api/triggeredwebjobs/DataProcessor/run");
            request.Method = "POST";
            var byteArray = Encoding.ASCII.GetBytes("username:password"); //we could find user name and password in Azure web app publish profile 
            request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(byteArray));
            request.ContentLength = 0;
            try
            {
                var response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception e)
            {

            }
        }
    }

}
