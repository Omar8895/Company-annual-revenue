using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        string str1;
        float size1;
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        public string txt_string1
        {
            get
            {
                if (textBox2.Text == "") 
                {
                    str1 = textBox1.Text;
                }

                else
                {
                    str1 = textBox2.Text;   
                }

                return str1;
            }

            set
            {
                textBox1.Text = value;
            }
        }

        public string txt_font1
        {
            get 
            {
                if ( radioButton1.Checked == true)
                {
                    str1 = "Times New Roman";
                }

                if ( radioButton2.Checked == true) 
                {
                    str1 = "Arial";
                }

                if ( radioButton3.Checked == true)
                {
                    str1 = "Courier New";
                }

                return str1;
            
            }

            set

            {
                str1 = value;

                if ( str1 == "Times New Roman")
                {
                    radioButton1.Checked = true;
                }

                if ( str1 == "Arial")
                {
                    radioButton2.Checked = true;
                }

                if (str1 == "New Courier")
                {
                    radioButton3.Checked = true;
                }

            }
        }

        public float txt_size1
        {
            get
            { 
                if ( radioButton4.Checked == true)
                {
                    size1 = 16; 
                }

                if (radioButton5.Checked == true)
                {
                    size1 = 20;
                }

                if (radioButton6.Checked == true)
                {
                    size1 = 24;
                }

                return size1;
            }

            set
            {
                size1 = value;

                if ( size1 == 16 )
                {
                    radioButton4.Checked = true;
                }

                if (size1 == 20)
                {
                    radioButton5.Checked = true;
                }

                if (size1 == 24)
                {
                    radioButton6.Checked = true;
                }
            }
        }

        public Color txt_color1
        {
            get
            {
                return colorDialog1.Color;
            }

            set
            {
                colorDialog1.Color = value;
            }
        }
    }
}
