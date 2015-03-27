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
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
            codingLabel.Text = "" + timeCoding;
            gamingLabel.Text = "" + timeGaming;
            othersLabel.Text = "" + timeOthers;
        }

        private int timeCoding;
        private int timeGaming;
        private int timeOthers;

        public void SetStats(int cod, int gam, int oth)
        {
            timeCoding = cod;
            timeGaming = gam;
            timeOthers = oth;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            codingLabel.Text = "" + timeCoding;
            gamingLabel.Text = "" + timeGaming;
            othersLabel.Text = "" + timeOthers;
        }


    }
}
