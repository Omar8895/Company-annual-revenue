using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        //Text 1 Data

        string m_HeadLine1; 
        Font m_HeadLineFont1;
        Brush m_HeadLineBrush1;
        Color m_HeadLineColor1;
        float x_title1;
        SizeF m_HeadLineSize1;

        //Text 2 Data 

        string m_HeadLineText2;
        Font m_HeadLineFont2;
        Brush m_HeadLineBrush2;
        Color m_HeadLineColor2;
        float x_title2;
        SizeF m_HeadLineSize2;



        //Table 

        Color t_Color;
        Rectangle t_Rect;
        Pen t_Pen;
        int st_Table_x = 900;
        int st_Table_y = 150; 
        int x_Space = 200; 
        int y_Space = 40;


        //Table Head 

        Color  t_head_Color;
        Rectangle t_head_Rect;
        Pen t_head_Pen;



        //Mid line of table

        Color mid_tLine_Color;
        Pen mid_tLine_Pen;
        Point mid_tLine_Pt1;
        Point mid_tLine_Pt2;


        //Mid line of haed

        Color mid_hLine_Color;
        Pen mid_hLine_Pen;
        Point mid_hLine_Pt1;
        Point mid_hLine_Pt2;


        //Horizontal line of table 

        Color hr_tLine_Color;
        Pen hr_tLine_Pen;


        //Table Data
 
        string[] Years = { "1987","1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997" };
        string[] Years1 = { "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997" };
        string[] Revenue = {"150", "170", "180", "175", "200", "250", "210", "240", "280", "140" };
        Color years_Color;
        Font years_Font ;
        Brush years_Brush;
        Color Rev_Color;
        Font Rev_Font;
        Brush Rev_Brush;
      


        //Head Data 

        string[] Head = { "Years", "Revenue" };
        Color head_Color;
        Font head_Font;
        Brush head_Brush;


        //X - Axis Line 

        Color x_LineColor;
        Pen x_Pen;
        Point x_PtStart;
        Point x_PtEnd;
        int st_x_x = 200;
        int st_x_y = 500;
        int end_x_x = 680;
        int end_x_y = 500;


        //Y - Axis Line 

        Color y_LineColor;
        Pen y_Pen;
        Point y_PtStart;
        Point y_PtEnd;


        //X - Axis Data 

        Color x_Data_Color;
        Font x_Data_Font;
        Brush x_Data_Brush;


        //Y - Axis Data 

        string[] y_Data = { "0","40", "80", "120", "160", "200", "240", "280" };
        Color y_Data_Color;
        Font y_Data_Font;
        Brush y_Data_Brush;


        //X Axis line 

        Color Axis_x_line_Color;
        Pen Axis_x_line_Pen;


        //Y Axis line 

        Color Axis_y_line_Color;
        Pen Axis_y_line_Pen;


        //graph points

        Color Graph_Lines_Color;
        Pen Graph_Lines_Pen;
   
        Point y1;
        Point y2;
        Point y3;
        Point y4;
        Point y5;
        Point y6;
        Point y7;
        Point y8;
        Point y9;
        Point y10;


        //Bar chart Data

        Color Bar_ForeColor;
        Color Bar_BackColor;
        Rectangle Bar_y1;
        Rectangle Bar_y2;
        Rectangle Bar_y3;
        Rectangle Bar_y4;
        Rectangle Bar_y5;
        Rectangle Bar_y6;
        Rectangle Bar_y7;
        Rectangle Bar_y8;
        Rectangle Bar_y9;
        Rectangle Bar_y10;
        Brush Bar_Brush;
        HatchStyle Bar_Style;


        //Word Year 

        string wordYear;
        Font wordYearFont;
        Brush wordYearBrush;
        Color wordYearColor;
        Point WordYearLocation;



        //Word Avenue 

        string wordRevenue;
        Font wordRevenueFont;
        Brush wordRevenueBrush;
        Color wordRevenueColor;
        Point WordRevenueLocation;



        public Form1()
        {
            InitializeComponent();


            //Text 1 Data

            m_HeadLine1 = "ABC Company";
            m_HeadLineFont1 = new Font("Times New Roman", 24 , FontStyle.Underline);
            m_HeadLineColor1 = Color.Red;
            m_HeadLineBrush1 = new SolidBrush(m_HeadLineColor1);
      
            //Text 2 Data 

            m_HeadLineText2 = "Annual Revenue";
            m_HeadLineFont2 = new Font("Times New Roman", 20, FontStyle.Underline);
            m_HeadLineColor2 = Color.Blue;
            m_HeadLineBrush2 = new SolidBrush(m_HeadLineColor2);


            //Table 

            t_Color = Color.Black;
            t_Rect = new Rectangle(st_Table_x,st_Table_y-50,x_Space*2,y_Space*10);
            t_Pen = new Pen(t_Color,2);



            //Mid line of table

             mid_tLine_Color = Color.Black;
             mid_tLine_Pen = new Pen (mid_tLine_Color,2);
             mid_tLine_Pt1 = new Point ( st_Table_x + x_Space , st_Table_y);
             mid_tLine_Pt2 = new Point ( st_Table_x + x_Space , st_Table_y + (y_Space *10)-50);



            //Mid line of haed

            mid_hLine_Color = Color.Black;
            mid_hLine_Pen = new Pen (mid_hLine_Color , 2);
            mid_hLine_Pt1 = new Point(st_Table_x + x_Space, st_Table_y );
            mid_hLine_Pt2 = new Point(st_Table_x + x_Space, st_Table_y-150);


            //Horizontal line of table 

             hr_tLine_Color = Color.Black;
             hr_tLine_Pen = new Pen (hr_tLine_Color , 2);


            //Table Data 

             years_Color = Color.Red;
             years_Font = new Font ("Times New Roman" , 15);
             years_Brush = new SolidBrush(years_Color);
             Rev_Color = Color.Blue;
             Rev_Font = new Font("Times New Roman", 15);
             Rev_Brush = new SolidBrush(Rev_Color);

            //Head Data

            head_Color = Color.Green;
            head_Font = new Font ("Times New Roman",15);
            head_Brush = new SolidBrush(head_Color);


            //Table Head

            t_head_Color = Color.Black;
            t_head_Rect = new Rectangle (st_Table_x,st_Table_y-100,400,50);
            t_head_Pen = new Pen (t_head_Color , 2);



            //X - Axis Line 

            x_LineColor = Color.Black;
            x_Pen = new Pen (x_LineColor , 2);
            x_PtStart = new Point (st_x_x , st_x_y);
            x_PtEnd = new Point (end_x_x + 40, end_x_y);
            x_Pen.EndCap = LineCap.Custom;
            x_Pen.CustomEndCap = new AdjustableArrowCap(6, 6);


            //Y - Axis Line 

             y_LineColor = Color.Black;
             y_Pen = new Pen (y_LineColor , 2);
             y_PtStart = new Point (st_x_x, st_x_y);
             y_PtEnd = new Point (st_x_x , st_x_y - 400 );
             y_Pen.EndCap = LineCap.Custom;
             y_Pen.CustomEndCap = new AdjustableArrowCap(6, 6); 


            //X - Axis Data 

            x_Data_Color = Color.Red;
            x_Data_Font = new Font ("Times New Roman",10);
            x_Data_Brush = new SolidBrush(x_Data_Color);


            //Y - Axis Data 
;
            y_Data_Color = Color.Red;
            y_Data_Font = new Font("Times New Roman", 10);
            y_Data_Brush = new SolidBrush(y_Data_Color);


            //Axis x lines 

             Axis_x_line_Color = Color.Black;
             Axis_x_line_Pen = new Pen(Axis_x_line_Color, 2);

            //Axis y lines

             Axis_y_line_Color = Color.Black;
             Axis_y_line_Pen = new Pen (Axis_y_line_Color , 2);
            


            //graph Data

             Graph_Lines_Color = Color.Blue;
             Graph_Lines_Pen = new Pen (Graph_Lines_Color , 3);



            //Bar chart Data

            Bar_ForeColor = Color.Red;
            Bar_BackColor = Color.Empty;
            Bar_Style = HatchStyle.BackwardDiagonal;
            Bar_Brush = new HatchBrush (Bar_Style , Bar_ForeColor , Bar_BackColor);


            //Word Year

            wordYear = "Years";
            wordYearFont = new Font ("Time New Roman",10);
            wordYearColor = Color.Black;
            wordYearBrush = new SolidBrush(wordYearColor);
            WordYearLocation = new Point(680, 510);


            //Word Avenue

            wordRevenue = "Revenue";
            wordRevenueFont = new Font("Time New Roman", 10);
            wordRevenueColor = Color.Black;
            wordRevenueBrush = new SolidBrush(wordRevenueColor);
            WordRevenueLocation = new Point(130, 100);



              
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            DisplayText1();
            DisplayText2();
            DisplayTable();
            DislplayMidLine();
            Display_Mid_head_Line();
            DisplayHorizontalLine();
            Display_Table_Head();
            DisplayYears();
            DisplayRevenue();
            Display_x_axis();
            Display_y_axis();
            Display_x_axis_data();
            Display_y_axis_data();
            Display_Head_Data();
            Display_x_axis_lines();
            Display_y_axis_lines();
            Draw_Graph();
            Draw_Bar_Chart();
            Display_Year_Word();
            Display_Avenue_Word();


        }

        public void DisplayText1()
        {
          
            Graphics g = this.CreateGraphics();
            m_HeadLineSize1 = g.MeasureString(m_HeadLine1, m_HeadLineFont1);
            x_title1 = (this.Width - m_HeadLineSize1.Width)/2;
            g.DrawString(m_HeadLine1, m_HeadLineFont1, m_HeadLineBrush1, x_title1, 50 );
        }


        public void DisplayText2()
        {
            Graphics g = this.CreateGraphics();
            m_HeadLineSize2 = g.MeasureString(m_HeadLineText2, m_HeadLineFont2);
            x_title2 = (this.Width - m_HeadLineSize2.Width) / 2;
            g.DrawString(m_HeadLineText2, m_HeadLineFont2, m_HeadLineBrush2, x_title2, 110);
        }



        public void DisplayTable()
        {
            Graphics g = this.CreateGraphics();
            g.DrawRectangle(t_Pen, t_Rect);
        }


        public void DislplayMidLine()
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(mid_tLine_Pen, mid_tLine_Pt1, mid_tLine_Pt2);
        }

        public void DisplayHorizontalLine()
        {
            Graphics g = this.CreateGraphics();

            for ( int  i = 0 ; i < 10; i ++ ) 
            {
                g.DrawLine(hr_tLine_Pen, new Point(st_Table_x, st_Table_y + y_Space * i-50),
                 new Point(st_Table_x + 2 * x_Space, st_Table_y + y_Space * i -50 ));
            }     
        }

        public void Display_Table_Head()
        {
            Graphics g = this.CreateGraphics();

            g.DrawRectangle(t_head_Pen, t_head_Rect);
        }

        public void Display_Head_Data()
        {
            Graphics g = this.CreateGraphics();

            for ( int i = 0; i < 2; i ++)
            {
                g.DrawString(Head[i], head_Font, head_Brush, new Point( st_Table_x +( x_Space*i) + 60,st_Table_y-90));
            }
        }

        public void Display_Mid_head_Line()
        {
            Graphics g = this.CreateGraphics();

            g.DrawLine(mid_hLine_Pen, mid_hLine_Pt1, mid_hLine_Pt2);
        }

        public void DisplayYears()
        {
            Graphics g = this.CreateGraphics();

            for ( int i = 0; i < 10; i ++ )
            {
                g.DrawString(Years1[i], years_Font, years_Brush,st_Table_x +70, (st_Table_y+ 40 * i)-40) ;
            }
        }

        public void DisplayRevenue()
        {
            Graphics g = this.CreateGraphics();

            for (int i = 0; i < 10; i++)
            {
                g.DrawString(Revenue[i], Rev_Font, Rev_Brush, st_Table_x + x_Space + 70, (st_Table_y + 40 * i )-40);
            }
        }


        public void Display_x_axis()
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(x_Pen, x_PtStart, x_PtEnd);
        }


        public void Display_y_axis()
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(y_Pen , y_PtStart , y_PtEnd);
        }

        public void Display_x_axis_data()
        {
            Graphics g = this.CreateGraphics();
            
            for ( int i = 0; i <= 10; i ++ ) 
            {
                g.DrawString(Years[i], x_Data_Font, x_Data_Brush, new Point((st_x_x +40 * i)-15, st_x_y+10));
            }
        }


        public void Display_y_axis_data()
        {
            Graphics g = this.CreateGraphics();

            for (int i = 0 ; i < 8; i ++ )
            {
                g.DrawString(y_Data[i], x_Data_Font, x_Data_Brush, new Point(st_x_x - 40 , (st_x_y -40 *i)-10));
            }
        }


        public void Display_x_axis_lines()
        {
            Graphics g = this.CreateGraphics();

            for ( int i = 0; i<= 10; i ++ ) 
            {
                g.DrawLine(Axis_x_line_Pen, new Point(st_x_x + 40 * i , st_x_y-5), new Point(st_x_x + 40 *i , st_x_y ));
            }
        }


        public void Display_y_axis_lines()
        {
            Graphics g = this.CreateGraphics();

            for ( int i = 0; i <8; i++ )
            {
                g.DrawLine(Axis_y_line_Pen, new Point(st_x_x+5, st_x_y - 40 * i), new Point(st_x_x , st_x_y - 40 * i));
            }
        }


        protected void Draw_Graph()
        {
             Graphics g = this.CreateGraphics();

            y1 = new Point(240, 355);
            y2 = new Point(280 , 330);
            y3 = new Point(320 , 320);
            y4 = new Point(360 , 330);
            y5 = new Point(400 ,300);
            y6 = new Point(440 , 250);
            y7 = new Point(480 ,290);
            y8 = new Point(520 , 260);
            y9 = new Point(560 , 220);
            y10 = new Point(600 , 360);

            g.DrawLine(Graph_Lines_Pen, y1, y2);
            g.DrawLine(Graph_Lines_Pen, y2, y3);
            g.DrawLine(Graph_Lines_Pen, y3, y4);
            g.DrawLine(Graph_Lines_Pen, y4, y5);
            g.DrawLine(Graph_Lines_Pen, y5, y6);
            g.DrawLine(Graph_Lines_Pen, y6, y7);
            g.DrawLine(Graph_Lines_Pen, y7, y8);
            g.DrawLine(Graph_Lines_Pen, y8, y9);
            g.DrawLine(Graph_Lines_Pen, y9, y10);
        }


        protected void Draw_Bar_Chart()
        {
            Graphics g = this.CreateGraphics();

            Bar_y1 = new Rectangle(230, 355, 20, 145);
            Bar_y2 = new Rectangle(270, 330, 20, 170);
            Bar_y3 = new Rectangle(310, 320, 20, 180);
            Bar_y4 = new Rectangle(350, 330, 20, 170);
            Bar_y5 = new Rectangle(390, 300, 20, 200);
            Bar_y6 = new Rectangle(430, 250, 20, 250);
            Bar_y7 = new Rectangle(470, 290, 20, 210);
            Bar_y8 = new Rectangle(510, 260, 20, 240);
            Bar_y9 = new Rectangle(550, 220, 20, 280);
            Bar_y10 = new Rectangle(590, 360, 20, 140);

            g.FillRectangle(Bar_Brush, Bar_y1);
            g.FillRectangle(Bar_Brush, Bar_y2);
            g.FillRectangle(Bar_Brush, Bar_y3);
            g.FillRectangle(Bar_Brush, Bar_y4);
            g.FillRectangle(Bar_Brush, Bar_y5);
            g.FillRectangle(Bar_Brush, Bar_y6);
            g.FillRectangle(Bar_Brush, Bar_y7);
            g.FillRectangle(Bar_Brush, Bar_y8);
            g.FillRectangle(Bar_Brush, Bar_y9);
            g.FillRectangle(Bar_Brush, Bar_y10);
        }


        public void Display_Year_Word()
        {
            Graphics g = CreateGraphics();

            g.DrawString(wordYear, wordYearFont, wordYearBrush, WordYearLocation);
        }


        public void Display_Avenue_Word()
        {
            Graphics g = CreateGraphics();

            g.DrawString(wordRevenue, wordRevenueFont, wordRevenueBrush, WordRevenueLocation);
        }


      
        protected override void OnResize(EventArgs e)
        {
            Invalidate();
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((int)e.KeyChar)
            {
                case 2://Blue
                    Graph_Lines_Color = Color.Blue;
                    break;

                case 7://Green
                    Graph_Lines_Color = Color.Green;
                    break;

                case 18://Red
                    Graph_Lines_Color = Color.Red;
                    break;

            }
            Invalidate();

            Graph_Lines_Pen.Color = Graph_Lines_Color;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
         {
             if ( e.X > st_x_x && e.X < end_x_x && e.Y < st_x_y && e.Y > end_x_y -400)
             {
                 if ( e.Button == MouseButtons.Right ) 
                 {
                    this.ContextMenuStrip = rectangle;

                 }
     
             }

            else
            {
                this.ContextMenuStrip = Line;
            }

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton1.Checked = true;
            toolStripButton2.Checked = false;
            toolStripButton3.Checked = false;

            redToolStripMenuItem.Checked = true;
            greenToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;

            Graph_Lines_Color = Color.Red;
            Graph_Lines_Pen.Color = Graph_Lines_Color;
            Invalidate();
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton1.Checked = false;
            toolStripButton2.Checked = true;
            toolStripButton3.Checked = false;

            redToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = true;
            blueToolStripMenuItem.Checked = false;

            Graph_Lines_Color = Color.Green;
            Graph_Lines_Pen.Color = Graph_Lines_Color;
            Invalidate();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton1.Checked = false;
            toolStripButton2.Checked = false;
            toolStripButton3.Checked = true;

            redToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = true;

            Graph_Lines_Color = Color.Blue;
            Graph_Lines_Pen.Color = Graph_Lines_Color;
            Invalidate();
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton4.Checked = true;
            toolStripButton5.Checked = false;
            toolStripButton6.Checked = false;

            solidToolStripMenuItem.Checked = true;
            dotToolStripMenuItem.Checked = false;
            dashToolStripMenuItem.Checked = false;

            Graph_Lines_Pen.DashStyle= DashStyle.Solid;
            Invalidate();
        }

        private void dashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton4.Checked = false;
            toolStripButton5.Checked = true;
            toolStripButton6.Checked = false;

            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = false;
            dashToolStripMenuItem.Checked = true;

            Graph_Lines_Pen.DashStyle = DashStyle.Dash;
            Invalidate();
        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton4.Checked = false;
            toolStripButton5.Checked = false;
            toolStripButton6.Checked = true;

            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = true;
            dashToolStripMenuItem.Checked = false;

            Graph_Lines_Pen.DashStyle = DashStyle.DashDot;
            Invalidate();
        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripButton7.Checked = true;
            toolStripButton8.Checked = false;
            toolStripButton9.Checked = false;

            redToolStripMenuItem1.Checked = true;
            greenToolStripMenuItem1.Checked = false;
            blueToolStripMenuItem1.Checked = false;

            Bar_ForeColor = Color.Red;
            Bar_Brush = new HatchBrush(Bar_Style,Bar_ForeColor , Bar_BackColor);
            Invalidate();
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripButton7.Checked = false;
            toolStripButton8.Checked = true;
            toolStripButton9.Checked = false;

            redToolStripMenuItem1.Checked = false;
            greenToolStripMenuItem1.Checked = true;
            blueToolStripMenuItem1.Checked = false;

            Bar_ForeColor = Color.Green;
            Bar_Brush = new HatchBrush(Bar_Style, Bar_ForeColor, Bar_BackColor);
            Invalidate();
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripButton7.Checked = false;
            toolStripButton8.Checked = false;
            toolStripButton9.Checked = true;

            redToolStripMenuItem1.Checked = false;
            greenToolStripMenuItem1.Checked = false;
            blueToolStripMenuItem1.Checked = true;

            Bar_ForeColor = Color.Blue;
            Bar_Brush = new HatchBrush(Bar_Style, Bar_ForeColor, Bar_BackColor);
            Invalidate();
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton10.Checked = true;
            toolStripButton11.Checked = false;
            toolStripButton12.Checked = false;

            rightToolStripMenuItem.Checked = true;
            leftToolStripMenuItem.Checked = false;
            crossToolStripMenuItem.Checked = false;

            Bar_Style = HatchStyle.BackwardDiagonal;
            Bar_Brush = new HatchBrush(Bar_Style, Bar_ForeColor, Bar_BackColor);
            Invalidate();
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton10.Checked = false;
            toolStripButton11.Checked = true;
            toolStripButton12.Checked = false;

            rightToolStripMenuItem.Checked = false;
            leftToolStripMenuItem.Checked = true;
            crossToolStripMenuItem.Checked = false;

            Bar_Style = HatchStyle.ForwardDiagonal;
            Bar_Brush = new HatchBrush(Bar_Style, Bar_ForeColor, Bar_BackColor);
            Invalidate();
        }

        private void crossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton10.Checked = false;
            toolStripButton11.Checked = false;
            toolStripButton12.Checked = true;

            rightToolStripMenuItem.Checked = false;
            leftToolStripMenuItem.Checked = false;
            crossToolStripMenuItem.Checked = true;
            Bar_Style = HatchStyle.Cross;
            Bar_Brush = new HatchBrush(Bar_Style, Bar_ForeColor, Bar_BackColor);
            Invalidate();
        }

 
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X > st_x_x +40 && e.X < end_x_x -40 && e.Y < st_x_y  && e.Y > end_x_y - 281)
            {
                Year.Text = "Years = " + (((e.X - st_x_x) / 40) + 1987);
                toolStripStatusLabel2.Text ="Revenue = " + (st_x_y - e.Y);
            }
        }

        private void companyNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgbox d = new dlgbox();
            DialogResult res;
            d.txt_string = m_HeadLine1;
            d.txt_color = m_HeadLineColor1;
            d.txt_font = m_HeadLineFont1.Name;
            d.txt_size = m_HeadLineFont1.Size;
            res = d.ShowDialog();
           if (res == DialogResult.OK)
           {
                this.m_HeadLine1 = d.txt_string; 
                this.m_HeadLineColor1=d.txt_color;
                this.m_HeadLineFont1 = new Font(d.txt_font, d.txt_size , FontStyle.Underline);
                this.m_HeadLineBrush1=new SolidBrush(m_HeadLineColor1);

                Invalidate();
           } 
        }

        private void reportNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report f = new Report();
            DialogResult res;
            f.txt_string1 =this.m_HeadLineText2;
            f.txt_color1 = this.m_HeadLineColor2;
            f.txt_font1 = this.m_HeadLineFont2.Name;
            f.txt_size1 = this.m_HeadLineFont2.Size;
            res = f.ShowDialog();

            if ( res == DialogResult.OK )
            {
                this.m_HeadLineText2 = f.txt_string1;
                this.m_HeadLineColor2 = f.txt_color1;
                this.m_HeadLineFont2 = new Font (f.txt_font1 , f.txt_size1, FontStyle.Underline);
                this.m_HeadLineBrush2 = new SolidBrush(m_HeadLineColor2);

                Invalidate();
            }
        }
    }
}

