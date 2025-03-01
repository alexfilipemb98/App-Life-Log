using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = @"C:\Program Files\R\R-4.4.2\bin\R.exe",
                Arguments = "-e \"library(Rcmdr)\"",
                RedirectStandardOutput = false,
                RedirectStandardError = false,
                UseShellExecute = true,
                CreateNoWindow = false
            };

            try
            {
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao abrir o Rcmdr: " + ex.Message);
            }

        }
    }
}
