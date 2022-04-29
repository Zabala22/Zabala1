namespace Full_name_on_message_box
{
    partial class FullNameDisplayer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstnametextBox = new System.Windows.Forms.TextBox();
            this.MiddlenametextBox = new System.Windows.Forms.TextBox();
            this.LastnametextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FullnametextBox = new System.Windows.Forms.TextBox();
            this.Fullnamebutton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Middle Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // FirstnametextBox
            // 
            this.FirstnametextBox.Location = new System.Drawing.Point(109, 25);
            this.FirstnametextBox.Name = "FirstnametextBox";
            this.FirstnametextBox.Size = new System.Drawing.Size(193, 23);
            this.FirstnametextBox.TabIndex = 0;
            // 
            // MiddlenametextBox
            // 
            this.MiddlenametextBox.Location = new System.Drawing.Point(109, 65);
            this.MiddlenametextBox.Name = "MiddlenametextBox";
            this.MiddlenametextBox.Size = new System.Drawing.Size(193, 23);
            this.MiddlenametextBox.TabIndex = 1;
            // 
            // LastnametextBox
            // 
            this.LastnametextBox.Location = new System.Drawing.Point(109, 107);
            this.LastnametextBox.Name = "LastnametextBox";
            this.LastnametextBox.Size = new System.Drawing.Size(193, 23);
            this.LastnametextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Full Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FullnametextBox
            // 
            this.FullnametextBox.Location = new System.Drawing.Point(109, 176);
            this.FullnametextBox.Name = "FullnametextBox";
            this.FullnametextBox.Size = new System.Drawing.Size(323, 23);
            this.FullnametextBox.TabIndex = 11;
            // 
            // Fullnamebutton
            // 
            this.Fullnamebutton.Location = new System.Drawing.Point(357, 24);
            this.Fullnamebutton.Name = "Fullnamebutton";
            this.Fullnamebutton.Size = new System.Drawing.Size(75, 23);
            this.Fullnamebutton.TabIndex = 3;
            this.Fullnamebutton.Text = "Full Name";
            this.Fullnamebutton.UseVisualStyleBackColor = true;
            this.Fullnamebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(357, 64);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(75, 23);
            this.Clearbutton.TabIndex = 4;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(357, 102);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 5;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // FullNameDisplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 220);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.Fullnamebutton);
            this.Controls.Add(this.FullnametextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastnametextBox);
            this.Controls.Add(this.MiddlenametextBox);
            this.Controls.Add(this.FirstnametextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FullNameDisplayer";
            this.Text = "Full Name Displayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox FirstnametextBox;
        private TextBox MiddlenametextBox;
        private TextBox LastnametextBox;
        private Label label4;
        private TextBox FullnametextBox;
        private Button Fullnamebutton;
        private Button Clearbutton;
        private Button Exitbutton;
    }
}