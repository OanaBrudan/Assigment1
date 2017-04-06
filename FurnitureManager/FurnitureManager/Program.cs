using FurnitureManager.BL;
using FurnitureManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureManager
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
           // Application.Run(new OrdersF());
            //Application.Run(new ProductsF());
           // Application.Run(new UsersF());
            Application.Run(new LoginF());
        }
    }
}
///cment