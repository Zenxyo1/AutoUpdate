using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoUpdate;

namespace AutoUpdate
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // setup the auto update, and exit if there was an update
            // change the line below to your github repo where "AutoUpdate" is (YourAppName)/(YourRepoName)
            Updater.GitHubRepo = "/Zenxyo1/AutoUpdate";
            if (Updater.AutoUpdate(args))
                return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
