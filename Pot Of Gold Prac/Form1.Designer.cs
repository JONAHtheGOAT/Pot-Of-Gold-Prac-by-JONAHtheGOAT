namespace Pot_Of_Gold_Prac
{
    partial class FormDoors
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
            this.GreenDoor = new System.Windows.Forms.CheckBox();
            this.BlueDoor = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.redDoor = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.redDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // GreenDoor
            // 
            this.GreenDoor.AutoSize = true;
            this.GreenDoor.Location = new System.Drawing.Point(50, 354);
            this.GreenDoor.Name = "GreenDoor";
            this.GreenDoor.Size = new System.Drawing.Size(58, 17);
            this.GreenDoor.TabIndex = 8;
            this.GreenDoor.Text = "Door 1";
            this.GreenDoor.UseVisualStyleBackColor = true;
            this.GreenDoor.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BlueDoor
            // 
            this.BlueDoor.AutoSize = true;
            this.BlueDoor.Location = new System.Drawing.Point(353, 354);
            this.BlueDoor.Name = "BlueDoor";
            this.BlueDoor.Size = new System.Drawing.Size(58, 17);
            this.BlueDoor.TabIndex = 9;
            this.BlueDoor.Text = "Door 2";
            this.BlueDoor.UseVisualStyleBackColor = true;
            this.BlueDoor.CheckedChanged += new System.EventHandler(this.Door2_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(643, 354);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(58, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Door 3";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // redDoor
            // 
            this.redDoor.Image = global::Pot_Of_Gold_Prac.Properties.Resources.door_3;
            this.redDoor.Location = new System.Drawing.Point(543, 156);
            this.redDoor.Name = "redDoor";
            this.redDoor.Size = new System.Drawing.Size(245, 184);
            this.redDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redDoor.TabIndex = 7;
            this.redDoor.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pot_Of_Gold_Prac.Properties.Resources.door_2;
            this.pictureBox3.Location = new System.Drawing.Point(317, 147);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(118, 193);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pot_Of_Gold_Prac.Properties.Resources.door_1;
            this.pictureBox1.Location = new System.Drawing.Point(41, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pot_Of_Gold_Prac.Properties.Resources.Capture1;
            this.pictureBox2.Location = new System.Drawing.Point(251, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // FormDoors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.BlueDoor);
            this.Controls.Add(this.GreenDoor);
            this.Controls.Add(this.redDoor);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FormDoors";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.redDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox redDoor;
        private System.Windows.Forms.CheckBox GreenDoor;
        private System.Windows.Forms.CheckBox BlueDoor;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
    }
}

