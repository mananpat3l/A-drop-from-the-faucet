namespace Lab5a
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.color_button = new System.Windows.Forms.Button();
            this.closebutton1 = new System.Windows.Forms.Button();
            this.quantity_trackBar = new System.Windows.Forms.TrackBar();
            this.tappictureBox = new System.Windows.Forms.PictureBox();
            this.ticktimer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.quantity_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tappictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // color_button
            // 
            this.color_button.BackColor = System.Drawing.SystemColors.Control;
            this.color_button.Location = new System.Drawing.Point(39, 12);
            this.color_button.Name = "color_button";
            this.color_button.Size = new System.Drawing.Size(75, 23);
            this.color_button.TabIndex = 0;
            this.color_button.Text = "Color";
            this.color_button.UseVisualStyleBackColor = true;
            this.color_button.Click += new System.EventHandler(this.color_button_Click);
            // 
            // closebutton1
            // 
            this.closebutton1.Location = new System.Drawing.Point(221, 12);
            this.closebutton1.Name = "closebutton1";
            this.closebutton1.Size = new System.Drawing.Size(75, 23);
            this.closebutton1.TabIndex = 1;
            this.closebutton1.Text = "Close";
            this.closebutton1.UseVisualStyleBackColor = true;
            this.closebutton1.Click += new System.EventHandler(this.closebutton1_Click);
            // 
            // quantity_trackBar
            // 
            this.quantity_trackBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quantity_trackBar.Location = new System.Drawing.Point(25, 73);
            this.quantity_trackBar.Name = "quantity_trackBar";
            this.quantity_trackBar.Size = new System.Drawing.Size(118, 45);
            this.quantity_trackBar.TabIndex = 0;
            this.quantity_trackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tappictureBox
            // 
            this.tappictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tappictureBox.Image = ((System.Drawing.Image)(resources.GetObject("tappictureBox.Image")));
            this.tappictureBox.Location = new System.Drawing.Point(12, 124);
            this.tappictureBox.Name = "tappictureBox";
            this.tappictureBox.Size = new System.Drawing.Size(251, 242);
            this.tappictureBox.TabIndex = 2;
            this.tappictureBox.TabStop = false;
            // 
            // ticktimer1
            // 
            this.ticktimer1.Tick += new System.EventHandler(this.ticktimer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(756, 749);
            this.Controls.Add(this.tappictureBox);
            this.Controls.Add(this.quantity_trackBar);
            this.Controls.Add(this.closebutton1);
            this.Controls.Add(this.color_button);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "A drop from bucket";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantity_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tappictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button color_button;
        private System.Windows.Forms.Button closebutton1;
        private System.Windows.Forms.TrackBar quantity_trackBar;
        private System.Windows.Forms.PictureBox tappictureBox;
        private System.Windows.Forms.Timer ticktimer1;
    }
}

