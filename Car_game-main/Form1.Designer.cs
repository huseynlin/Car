namespace Car_game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            back = new Button();
            stop = new Button();
            right = new PictureBox();
            left = new PictureBox();
            forward = new Button();
            car = new PictureBox();
            road = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)right).BeginInit();
            ((System.ComponentModel.ISupportInitialize)left).BeginInit();
            ((System.ComponentModel.ISupportInitialize)car).BeginInit();
            ((System.ComponentModel.ISupportInitialize)road).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(back);
            panel1.Controls.Add(stop);
            panel1.Controls.Add(right);
            panel1.Controls.Add(left);
            panel1.Controls.Add(forward);
            panel1.Location = new Point(477, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 970);
            panel1.TabIndex = 15;
            // 
            // back
            // 
            back.BackColor = Color.Green;
            back.Cursor = Cursors.Hand;
            back.FlatStyle = FlatStyle.Popup;
            back.ForeColor = Color.White;
            back.Location = new Point(12, 313);
            back.Margin = new Padding(4);
            back.Name = "back";
            back.Size = new Size(125, 54);
            back.TabIndex = 34;
            back.Text = "GERİ";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // stop
            // 
            stop.BackColor = Color.Maroon;
            stop.Cursor = Cursors.Hand;
            stop.FlatStyle = FlatStyle.Popup;
            stop.ForeColor = Color.White;
            stop.Location = new Point(12, 385);
            stop.Margin = new Padding(4);
            stop.Name = "stop";
            stop.Size = new Size(125, 54);
            stop.TabIndex = 33;
            stop.Text = "DAYAN";
            stop.UseVisualStyleBackColor = false;
            stop.Click += stop_Click;
            // 
            // right
            // 
            right.Cursor = Cursors.Hand;
            right.Image = (Image)resources.GetObject("right.Image");
            right.Location = new Point(86, 232);
            right.Name = "right";
            right.Size = new Size(51, 50);
            right.SizeMode = PictureBoxSizeMode.StretchImage;
            right.TabIndex = 32;
            right.TabStop = false;
            right.Click += right_Click;
            // 
            // left
            // 
            left.Cursor = Cursors.Hand;
            left.Image = (Image)resources.GetObject("left.Image");
            left.Location = new Point(12, 232);
            left.Name = "left";
            left.Size = new Size(51, 50);
            left.SizeMode = PictureBoxSizeMode.StretchImage;
            left.TabIndex = 31;
            left.TabStop = false;
            left.Click += left_Click;
            // 
            // forward
            // 
            forward.BackColor = Color.Navy;
            forward.Cursor = Cursors.Hand;
            forward.FlatStyle = FlatStyle.Popup;
            forward.ForeColor = Color.White;
            forward.Location = new Point(12, 159);
            forward.Margin = new Padding(4);
            forward.Name = "forward";
            forward.Size = new Size(125, 54);
            forward.TabIndex = 30;
            forward.Text = "İRƏLİ";
            forward.UseVisualStyleBackColor = false;
            forward.Click += forward_Click;
            // 
            // car
            // 
            car.BackColor = Color.Black;
            car.Image = (Image)resources.GetObject("car.Image");
            car.Location = new Point(200, 409);
            car.Name = "car";
            car.Size = new Size(77, 120);
            car.SizeMode = PictureBoxSizeMode.StretchImage;
            car.TabIndex = 13;
            car.TabStop = false;
            // 
            // road
            // 
            road.Image = (Image)resources.GetObject("road.Image");
            road.Location = new Point(0, 0);
            road.Margin = new Padding(4);
            road.Name = "road";
            road.Size = new Size(477, 970);
            road.SizeMode = PictureBoxSizeMode.StretchImage;
            road.TabIndex = 11;
            road.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(626, 970);
            Controls.Add(panel1);
            Controls.Add(car);
            Controls.Add(road);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)right).EndInit();
            ((System.ComponentModel.ISupportInitialize)left).EndInit();
            ((System.ComponentModel.ISupportInitialize)car).EndInit();
            ((System.ComponentModel.ISupportInitialize)road).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox car;
        private PictureBox road;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Button back;
        private Button stop;
        private PictureBox right;
        private PictureBox left;
        private Button forward;
    }
}
