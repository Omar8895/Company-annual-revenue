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
    public partial class dlgbox : Form
    {
        string str;

        float size;

        public dlgbox()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public string txt_string
        {
            set { textBox1.Text = value; }

            get
            {
                

                if (textBox2.Text == "")
                {
                    str = textBox1.Text;
                }

                else
                {
                    str = textBox2.Text;
                }

                return str;

            }
        }



        public string txt_font
        {
            set
            {
                str = value;

                if ( str == "Times New Roman" )
                {
                    radioButton1.Checked = true;
                }

                if ( str == "Arial")
                {
                    radioButton2.Checked = true;
                }

                if (str == "Courier New")
                {
                    radioButton3.Checked = true;
                }

            }

            get
            {
                
                if (radioButton1.Checked == true)
                {
                    str = "Times New Roman";
                }

                 if ( radioButton2.Checked == true) 
                {

                    str = "Arial";
                }

                 if ( radioButton3.Checked == true)
                {
                    str = "Courier New";
                }
                
                return str;
            } 
            
           
        }


        public float txt_size
        { 
            get
            {
                if ( radioButton4.Checked == true)
                {
                    size = 16;
                }

                if (radioButton5.Checked == true)
                {
                    size = 20;
                }

                if ( radioButton6.Checked == true)
                {
                    size = 24;
                }

                return size;
            }

            set
            {
                size = value;

                if ( size == 16 )
                { 

                    radioButton4.Checked = true;
                }

                if (size == 20 )

                {
                    radioButton5.Checked = true;
                }

                if ( size == 24 )
                {
                    radioButton6.Checked = true;    
                }

            }
        }


        public Color txt_color
        { 
            set
            {
                colorDialog1.Color = value;
            }

            get 
            {
                return colorDialog1.Color;
            }
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
  
            colorDialog1.ShowDialog();        
        }

       
    }
}
