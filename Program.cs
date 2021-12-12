using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace urunotomasyon
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new AnaSayfa());
        }
    }
}
