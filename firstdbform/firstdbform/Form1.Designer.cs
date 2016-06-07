namespace firstdbform
{
    partial class patientform
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
            this.txttesting = new System.Windows.Forms.TextBox();
            this.btnsearchrecord = new System.Windows.Forms.Button();
            this.txtfirst2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtlast2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtemail2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.groupupdate = new System.Windows.Forms.GroupBox();
            this.txtage2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupupdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttesting
            // 
            this.txttesting.Location = new System.Drawing.Point(31, 38);
            this.txttesting.Name = "txttesting";
            this.txttesting.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txttesting.Size = new System.Drawing.Size(342, 19);
            this.txttesting.TabIndex = 5;
            // 
            // btnsearchrecord
            // 
            this.btnsearchrecord.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchrecord.ForeColor = System.Drawing.Color.Black;
            this.btnsearchrecord.Location = new System.Drawing.Point(31, 81);
            this.btnsearchrecord.Name = "btnsearchrecord";
            this.btnsearchrecord.Size = new System.Drawing.Size(336, 23);
            this.btnsearchrecord.TabIndex = 8;
            this.btnsearchrecord.Text = "ENTER FIRSTNAME OF PATIENT TO UPDATE";
            this.btnsearchrecord.UseVisualStyleBackColor = true;
            this.btnsearchrecord.Click += new System.EventHandler(this.btnsearchrecord_Click);
            // 
            // txtfirst2
            // 
            this.txtfirst2.Location = new System.Drawing.Point(99, 44);
            this.txtfirst2.Name = "txtfirst2";
            this.txtfirst2.Size = new System.Drawing.Size(263, 19);
            this.txtfirst2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(5, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Firstname";
            // 
            // txtlast2
            // 
            this.txtlast2.Location = new System.Drawing.Point(96, 90);
            this.txtlast2.Name = "txtlast2";
            this.txtlast2.Size = new System.Drawing.Size(263, 19);
            this.txtlast2.TabIndex = 0;
          // this.txtlast2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Lasttname";
            // 
            // txtemail2
            // 
            this.txtemail2.Location = new System.Drawing.Point(96, 129);
            this.txtemail2.Name = "txtemail2";
            this.txtemail2.Size = new System.Drawing.Size(263, 19);
            this.txtemail2.TabIndex = 0;
           // this.txtemail2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Age";
            // 
            // btnupdate
            // 
            this.btnupdate.ForeColor = System.Drawing.Color.Black;
            this.btnupdate.Location = new System.Drawing.Point(96, 212);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(204, 23);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "UPDATE PATIENT RECORD";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // groupupdate
            // 
            this.groupupdate.Controls.Add(this.btnupdate);
            this.groupupdate.Controls.Add(this.label9);
            this.groupupdate.Controls.Add(this.label10);
            this.groupupdate.Controls.Add(this.label8);
            this.groupupdate.Controls.Add(this.label7);
            this.groupupdate.Controls.Add(this.txtage2);
            this.groupupdate.Controls.Add(this.txtemail2);
            this.groupupdate.Controls.Add(this.txtfirst2);
            this.groupupdate.Controls.Add(this.txtlast2);
            this.groupupdate.Location = new System.Drawing.Point(37, 131);
            this.groupupdate.Name = "groupupdate";
            this.groupupdate.Size = new System.Drawing.Size(376, 272);
            this.groupupdate.TabIndex = 10;
            this.groupupdate.TabStop = false;
            this.groupupdate.Visible = false;
            // 
            // txtage2
            // 
            this.txtage2.Location = new System.Drawing.Point(96, 163);
            this.txtage2.Name = "txtage2";
            this.txtage2.Size = new System.Drawing.Size(263, 19);
            this.txtage2.TabIndex = 0;
          //  this.txtage2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(411, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // patientform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(516, 444);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupupdate);
            this.Controls.Add(this.btnsearchrecord);
            this.Controls.Add(this.txttesting);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "patientform";
            this.Text = "PATIENT INFO";
           // this.Load += new System.EventHandler(this.Form1_Load);
            this.groupupdate.ResumeLayout(false);
            this.groupupdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttesting;
        private System.Windows.Forms.Button btnsearchrecord;
        private System.Windows.Forms.TextBox txtfirst2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtlast2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtemail2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.GroupBox groupupdate;
        private System.Windows.Forms.TextBox txtage2;
        private System.Windows.Forms.Button button1;
    }
}

