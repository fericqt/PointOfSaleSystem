using FerPROJ;
using PointOfSaleForms;
using PointOfSaleSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            CustomCurrentLogin.Version = "v" + version.ToString();
            Login();


            void Login()
            {
                if (new FormLayer.ManageForm().ManageLogin())
                {
                    RunSplasher();
                }
            }

            void RunApplication()
            {

                FrmMainDashboard f = new FrmMainDashboard();
                Application.Run(f);



            }

            void RunSplasher()
            {
                SplasherFormSettings.ShowSplash();
                int currentPercentage = 5;
                SplasherFormSettings.Instance.SetStatus("Loading . . .");
                Application.DoEvents();
                Thread.Sleep(1000);
                while (currentPercentage <= 100)
                {
                    SplasherFormSettings.Instance.SetLoadingPerc(currentPercentage);
                    if (currentPercentage == 10)
                    {
                        SplasherFormSettings.Instance.SetStatus("Initializing Components . . .");
                    }
                    else if (currentPercentage == 50)
                    {
                        SplasherFormSettings.Instance.SetStatus("Connecting to Database . . .");
                    }
                    else if (currentPercentage == 80)
                    {
                        SplasherFormSettings.Instance.SetStatus("Done . . .");
                    }
                    Application.DoEvents();
                    Thread.Sleep(20);
                    currentPercentage++;
                }
                Application.DoEvents();
                RunApplication();
            }



        }

    }
}
