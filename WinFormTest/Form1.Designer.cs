namespace WinFormTest
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.smile = new System.Windows.Forms.PictureBox();
            this.tank1 = new System.Windows.Forms.PictureBox();
            this.down = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tank1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(624, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.smile);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 453);
            this.panel1.TabIndex = 8;
            // 
            // smile
            // 
            this.smile.Image = global::WinFormTest.Properties.Resources._1497881345_smiley__18;
            this.smile.Location = new System.Drawing.Point(247, 162);
            this.smile.Name = "smile";
            this.smile.Size = new System.Drawing.Size(65, 71);
            this.smile.TabIndex = 7;
            this.smile.TabStop = false;
            // 
            // tank1
            // 
            this.tank1.Image = global::WinFormTest.Properties.Resources._1497804241_gaming_game_play_multimedia_console_36;
            this.tank1.Location = new System.Drawing.Point(594, 12);
            this.tank1.Name = "tank1";
            this.tank1.Size = new System.Drawing.Size(67, 58);
            this.tank1.TabIndex = 5;
            this.tank1.TabStop = false;
            // 
            // down
            // 
            this.down.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.down.Image = global::WinFormTest.Properties.Resources._1497803601_icon_arrow_down_b;
            this.down.Location = new System.Drawing.Point(631, 276);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(30, 29);
            this.down.TabIndex = 4;
            this.down.UseVisualStyleBackColor = false;
            this.down.Click += new System.EventHandler(this.Button_Click);
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.right.Image = global::WinFormTest.Properties.Resources._1497803601_icon_arrow_right_b;
            this.right.Location = new System.Drawing.Point(667, 241);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(30, 29);
            this.right.TabIndex = 3;
            this.right.UseVisualStyleBackColor = false;
            this.right.Click += new System.EventHandler(this.Button_Click);
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.White;
            this.left.Image = global::WinFormTest.Properties.Resources._1497803601_icon_arrow_left_b;
            this.left.Location = new System.Drawing.Point(594, 241);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(30, 29);
            this.left.TabIndex = 1;
            this.left.UseVisualStyleBackColor = false;
            this.left.Click += new System.EventHandler(this.Button_Click);
            // 
            // up
            // 
            this.up.Image = global::WinFormTest.Properties.Resources._1497803601_icon_arrow_up_b;
            this.up.Location = new System.Drawing.Point(631, 206);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(30, 29);
            this.up.TabIndex = 0;
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.Button_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Orange;
            this.start.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.start.Location = new System.Drawing.Point(594, 350);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(103, 35);
            this.start.TabIndex = 9;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(730, 457);
            this.Controls.Add(this.start);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tank1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.down);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.up);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.smile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tank1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.PictureBox tank1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox smile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button start;

    }
}

