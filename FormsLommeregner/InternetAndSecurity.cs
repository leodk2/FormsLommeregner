using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net.NetworkInformation;
using System.Net;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;

namespace FormsLommeregner
{
    /// <summary>
    /// This is where we put all of the networking, security and sql stuff
    /// </summary>
    //This class shall NOT under any circumstances be public!!!!
    //If you need this class as public then there is something wrong with your code!
    public class InternetAndSecurity
    {
        static void Print(string a)
        {
            a = a.ToString();
            Console.WriteLine(a);
        }
        static void Print(object a)
        {
            a = a.ToString();
            Console.WriteLine(a);
        }
        #region SQL
        public void SqlConnect()
        {
            //initialize a new login screen to get the email.text property
            Login login = new Login();
            string userid = login.Email.Text;
            string Pass = userid;
            //create the connection to the sql server using my credentials
            //this should propably get changed at some point
            SqlConnection sqlConnection = new SqlConnection("Data Source = lommeregner.database.windows.net; " +
                "Initial Catalog = LommeregnerInLogs; Integrated Security = False; User ID = Leo; " +
                "Password = Bionicle2018; Connect Timeout = 60; Encrypt = True; " +
                "TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            
            //i'm not really sure what this does but it works
            
            //open the connection to the sql database
            sqlConnection.Open();
            
            try
            {
                SqlDataReader reader = null;
                SqlCommand cmd = new SqlCommand("select * from dbo.user_Codes", sqlConnection);
                reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    if(reader["Uid"].ToString().Equals("kim@strandjaegervej.dk"))
                    {
                        Print("Det virker");
                    }
                    else
                    {
                        break;
                    }
                    


                }
            }
            catch (Exception e)
            {
                Print(e.ToString());
            }
            
        }
        #endregion


        #region Internet
        public static object ShowNetworkInterfaces()
        {
            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            Console.WriteLine("Interface information for {0}",
                    computerProperties.HostName);
            if (nics == null || nics.Length < 1)
            {
                Console.WriteLine("  No network interfaces found.");
                return null;
            }

            Console.WriteLine("  Number of interfaces .................... : {0}", nics.Length);
            foreach (NetworkInterface adapter in nics)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties(); //  .GetIPInterfaceProperties();
                Console.WriteLine();
                Console.WriteLine(adapter.Description);
                Console.WriteLine(String.Empty.PadLeft(adapter.Description.Length, '='));
                Console.WriteLine("  Interface type .......................... : {0}", adapter.NetworkInterfaceType);
                Console.Write("  Physical address ........................ : ");
                PhysicalAddress address = adapter.GetPhysicalAddress();
                byte[] bytes = address.GetAddressBytes();
                for (int i = 0; i < bytes.Length; i++)
                {
                    // Display the physical address in hexadecimal.
                    Console.Write("{0}", bytes[i].ToString("X2"));
                    // Insert a hyphen after each byte, unless we are at the end of the 
                    // address.
                    if (i != bytes.Length - 1)
                    {
                        Console.Write("-");
                    }
                    Print(nics.ToString());
                       
                }
                //Console.WriteLine(nics);
                return nics;
            }
            Console.WriteLine(nics);
            return nics;
        }
        #endregion

        public void Run()
        {
            ShowNetworkInterfaces();
            SqlConnect();
        }
    }
}
