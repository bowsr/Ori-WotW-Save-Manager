using System;
using System.Windows.Forms;

namespace OriWotWSaveManager {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            FileHandler.CreateSaveFileDir();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Console.WriteLine(Prompt.ShowDialog("text", "caption"));
        }
    }
}
