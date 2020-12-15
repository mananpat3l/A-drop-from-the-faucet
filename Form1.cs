using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//I, Manan Patel, 000826892 certify that this material is my original work.  No other person's work has been used without due acknowledgement.

namespace Lab5a
{
    /// <summary>
    /// This is the graphical form of a bucket filling up with the tap water and by using color dialog box one can change the colour of it.
    /// </summary>
    public partial class Form1 : Form
    {

        private Graphics g; //Encapsulates a GDI+ drawing surface
        private int h;     //to keep track of height
        private bool fill; //to check if bucket is filled or not 
        float[] flowRate = { 0, 180, 160, 140, 120, 100, 80, 60, 40, 20, 10 }; //to incerease
        private Color c = Color.White; //Represents a color, initially set to white
        public Form1()
        {
            
            InitializeComponent();
            quantity_trackBar.Value = 0; //initial value is 0
            this.Paint += new PaintEventHandler(Form1_Paint); //initializing the paint to draw bucket
            
        }
        // creating the bucket with diffent dimensions.
        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.White), 200, 400, 200 ,620);
            e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.White), 200, 620, 400, 620);
            e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.White), 400, 620, 400, 400);
        }
        private void color_button_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog(); //Colordialog box is setted up
            dlg.ShowDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                c = dlg.Color;
            }

        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();  //creates a graphics object
            if (fill)   //if bucket is filled
            {
                g.FillRectangle(new SolidBrush(BackColor), 201, 400, 349, 400); //this will graphically display a liquid filling a bucket 
                fill = false;
            }

            else
            {
                if (quantity_trackBar.Value > 0)  //if value of trackbar is greater than zero 
                {
                    ticktimer1.Interval = 300;
                    ticktimer1.Interval = (int)flowRate[quantity_trackBar.Value];
                }

                else if (quantity_trackBar.Value == 0) //tap will stop if trackbar value is 0
                {
                    ticktimer1.Stop();
                    ticktimer1.Stop(); //timer will stop
                    g.FillRectangle(new SolidBrush(BackColor), 201, 200, 15, 200 - h); //this will graphically display a rectangle
                }
            }

            ticktimer1.Start();
        
    }

        private void closebutton1_Click(object sender, EventArgs e)
        {
            Close();//to exit the form
        }

       


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //to restart when it fills up completely

        private void ticktimer1_Tick_1(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics(); //creates a graphics object
            graphics.FillRectangle(new SolidBrush(c), 201, 620 - h, 199, 1); //this will draw water falling form tap into bucket
            graphics.FillRectangle(new SolidBrush(c), 210, 200, 15, 420 - h + 1);
            h += 1;

            if ((395 - h) == 180) //if height of bucket is reached
            {
                fill = true;
                h = 0;  //counter set to 0 because tap was stopped
                ticktimer1.Stop(); //timer will stop
                quantity_trackBar.Value = 0;  //setting value of trackbar to 0
                graphics.FillRectangle(new SolidBrush(BackColor), 210, 200, 15, 96);//resets to the blackbackground again to restart when it fills up.
            }
        }
    }
}
//END