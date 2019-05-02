using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project05
{
    static class Program
    {
        /// <summary>
        /// Name: Matt Batchelder
        /// Date: 5/2/19
        /// Purpose: Store scores, names of teams, and the date in a persistant XML document
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
