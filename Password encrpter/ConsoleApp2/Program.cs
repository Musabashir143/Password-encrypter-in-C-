using System;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string username, password, stationid;
            string enc_password;
            username = Console.ReadLine();
            password = Console.ReadLine();
            stationid = Console.ReadLine();

            enc_password = Convert.ToBase64String(Encoding.UTF8.GetBytes(password));

            string path = @"C:\Users\STARIZ.PK\source\repos\k180267\K180267_Q1\PASSWORD.txt"; //change the path

            string clientHeader = username + "," + enc_password + "," + stationid + Environment.NewLine;

            
            if (!File.Exists(path))
            {
                using FileStream fs = File.Create(path);
                File.WriteAllText(path, clientHeader);
            }

            File.AppendAllText(path, clientHeader + Environment.NewLine);

        }
    }
}