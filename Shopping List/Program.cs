using Shopping_List.Properties;
using System;
using System.Windows.Forms;

namespace Shopping_List
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show splash screen
            using (var splash = new SplashForm())
            {
                splash.Show();
                Application.DoEvents(); // Forces splash to render

                // Simulate loading time
                System.Threading.Thread.Sleep(3000); // 3 seconds

                splash.Close();
            }

            // Launch main form
            Application.Run(new Form1());
        }
    }
}