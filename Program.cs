﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q5_Ran_Uram_Daniel_Geron
{
    internal static class Program
    {
        private static Eshop eshop = new Eshop();
        public static Eshop Eshop
        {
            get { return eshop; }
            set
            {
                eshop = value;
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
