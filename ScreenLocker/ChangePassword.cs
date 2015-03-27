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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            try
            {
                ReadXML();
            }
            catch (Exception)
            {
                password = "123";
                WriteXML();
            }
            InitializeComponent();
        }
        private string password;

        public void WriteXML()
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(string));

            using (var file = new System.IO.StreamWriter(
                @"YouReNotIntrestedInIt.xml"))
            {
                writer.Serialize(file, password);

                file.Close();
            }
        }

        public void ReadXML()
        {
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(string));
            using (var file = new System.IO.StreamReader(
                @"YouReNotIntrestedInIt.xml"))
            {
                password = (string)reader.Deserialize(file);
                file.Close();
            }

        }

        private void label3_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label4_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void passwordChange_Click(object sender, EventArgs e)
        {
            try
            {
                ReadXML();
            }
            catch (Exception)
            {
                if (password == "123")
                {
                    if (textBox2.Text == textBox3.Text)
                    {
                        password = textBox2.Text;
                        WriteXML();
                        this.Close();
                    }
                    else
                    {
                        label5.Text = "New password mismatch!";
                        label5.Visible = true;
                    }
                }
                else
                {
                    label5.Text = "Wrong current password!";
                    label5.Visible = true;
                }
            }
            if (password == textBox1.Text)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    password = textBox2.Text;
                    WriteXML();
                    this.Close();
                }
                else
                {
                    label5.Text = "New password mismatch!";
                    label5.Visible = true;
                }
            }
            else
            {
                label5.Text = "Wrong current password!";
                label5.Visible = true;
            }
        }

    }
}
