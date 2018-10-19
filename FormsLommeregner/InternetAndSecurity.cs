using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace FormsLommeregner
{
    /// <summary>
    /// This is where we put all of the security and sql stuff
    /// </summary>
    //This class shall NOT be public!!!!
    public class InternetAndSecurity
    {
        public void GetMacAddresss()
        {
            /*var macAddr =
            (
                from nic in NetworkInterface.GetAllNetworkInterfaces()
                where nic.OperationalStatus == OperationalStatus.Up
                select nic.GetPhysicalAddress().ToString()
            ).FirstOrDefault().ToString();
            Console.WriteLine(macAddr);*/


        }

        public string GetMacAddress()
        {
            string macAddresses = string.Empty;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }
            //This doesn't rlly work yet
            //It is for the formatting for the MAC-address
            //It doesn't hinder the programs ability to run though
            var regex = "(.{2})(.{2})(.{2})(.{2})(.{2})(.{2})";
            var replace = "$1:$2:$3:$4:$5:$6";
            var newformat = Regex.Replace(macAddresses, regex, replace);

            Console.WriteLine(macAddresses);
            return macAddresses;
        }

    }
}
