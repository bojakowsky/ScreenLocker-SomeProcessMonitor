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
    public partial class ProcessAddDelete : Form
    {
        private string[] pCoding;
        private string[] pGaming;
        private string[] pOthers;

        public ProcessAddDelete(ref string [] c, ref string [] g , ref string [] o)
        {
            InitializeComponent();
            pCoding = c;
            pGaming = g;
            pOthers = o;
            foreach (string s in pCoding)
            {
                if (!s.Equals(""))
                    listBox1.Items.Add(s);
            }

            foreach (string s in pGaming)
            {
                if (!s.Equals(""))
                    listBox2.Items.Add(s);
            }

            foreach (string s in pOthers)
            {
                if (!s.Equals(""))
                    listBox3.Items.Add(s);
            }
        }


        int returnIndexSearched(string[] buf, string searchFor)
        {
            int i = 0;
            foreach (string s in buf)
            {
                if (s.Equals(searchFor))
                    return i;
                ++i;
            }
            return 0;
        }

        private void button1_Click(object sender, EventArgs e) // delete from coding
        {
            pCoding[returnIndexSearched(pCoding, (string)listBox1.SelectedItem)] = "";
            listBox1.Items.Remove(listBox1.SelectedItem);

        }

        private void button2_Click(object sender, EventArgs e) // delete from games
        {
            pGaming[returnIndexSearched(pGaming, (string)listBox2.SelectedItem)] = "";
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e) // delete from others
        {
            pOthers[returnIndexSearched(pOthers, (string)listBox3.SelectedItem)] = "";
            listBox3.Items.Remove(listBox3.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e) //Add process
        {
            if (radioButton1.Checked)
            {
                addProcessToCoding(textBox1.Text);
                listBox1.Items.Add(textBox1.Text);
            }

            if (radioButton2.Checked)
            {
                addProcessToGaming(textBox1.Text);
                listBox2.Items.Add(textBox1.Text);
            }

            if (radioButton3.Checked)
            {
                addProcessToOthers(textBox1.Text);
                listBox3.Items.Add(textBox1.Text);
            }
            else { }
        }


        public void addProcessToCoding(string process_name)
        {
            int whereToAdd = pCoding.Count();
            try
            {
                pCoding[whereToAdd] = process_name;
            }
            catch (Exception)
            {
                Array.Resize(ref pCoding, whereToAdd+1);
                pCoding[whereToAdd] = process_name;
            }
        }

        public void addProcessToGaming(string process_name)
        {
            int whereToAdd = pGaming.Count();
            try
            {
                pGaming[whereToAdd] = process_name;
            }
            catch (Exception)
            {
                Array.Resize(ref pGaming, whereToAdd+1);
                pGaming[whereToAdd] = process_name;
            }
        }

        public void addProcessToOthers(string process_name)
        {
            int whereToAdd = pOthers.Count();
            try
            {
                pOthers[whereToAdd] = process_name;
            }
            catch (Exception)
            {
                Array.Resize(ref pOthers, whereToAdd+1);
                pOthers[whereToAdd] = process_name;
            }
        }
    }
}
