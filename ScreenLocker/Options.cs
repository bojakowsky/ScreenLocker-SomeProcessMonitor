using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenLocker
{
    public partial class Options : Form
    {
        private string[] pCoding;
        private string[] pGaming;
        private string[] pOthers;

        Stats Stats;
        public Options()
        {

            InitializeComponent();
        }
        public void optionsInit(ref string[] c, ref string[] g, ref string[] o, ref Stats stats)
        {
            pCoding = c;
            pGaming = g;
            pOthers = o;

            Stats = stats;
        }

        

        private void button5_Click(object sender, EventArgs e) //Add process
        {
            ProcessAddDelete p = new ProcessAddDelete(ref pCoding, ref pGaming, ref pOthers);
            p.ShowDialog();
        }



       
    }
}
