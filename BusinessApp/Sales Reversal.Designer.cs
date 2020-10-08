namespace BusinessApp
{
    partial class Sales_Reversal
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
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtreceiptnumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtproductid
            // 
            this.txtproductid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtproductid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductid.Location = new System.Drawing.Point(215, 124);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.ReadOnly = true;
            this.txtproductid.Size = new System.Drawing.Size(226, 26);
            this.txtproductid.TabIndex = 12;
            this.txtproductid.TextChanged += new System.EventHandler(this.txtproductid_TextChanged);
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(71, 130);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(119, 20);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "With Sales ID";
            // 
            // Button2
            // 
            this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(403, 313);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(107, 39);
            this.Button2.TabIndex = 10;
            this.Button2.Text = "NO";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.Red;
            this.Button1.Location = new System.Drawing.Point(79, 313);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(120, 43);
            this.Button1.TabIndex = 9;
            this.Button1.Text = "YES";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtproductname
            // 
            this.txtproductname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtproductname.BackColor = System.Drawing.Color.Red;
            this.txtproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductname.ForeColor = System.Drawing.Color.White;
            this.txtproductname.Location = new System.Drawing.Point(70, 61);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.ReadOnly = true;
            this.txtproductname.Size = new System.Drawing.Size(468, 29);
            this.txtproductname.TabIndex = 8;
            this.txtproductname.TextChanged += new System.EventHandler(this.txtproductname_TextChanged);
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(66, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(457, 20);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Are You Sure You Want To Cancel The Following Sale? ";
            // 
            // txtquantity
            // 
            this.txtquantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(215, 186);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.ReadOnly = true;
            this.txtquantity.Size = new System.Drawing.Size(226, 26);
            this.txtquantity.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quantity Sold";
            // 
            // txtreceiptnumber
            // 
            this.txtreceiptnumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtreceiptnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreceiptnumber.Location = new System.Drawing.Point(215, 237);
            this.txtreceiptnumber.Name = "txtreceiptnumber";
            this.txtreceiptnumber.ReadOnly = true;
            this.txtreceiptnumber.Size = new System.Drawing.Size(226, 26);
            this.txtreceiptnumber.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Receipt Number";
            // 
            // Sales_Reversal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 382);
            this.Controls.Add(this.txtreceiptnumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtproductid);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtproductname);
            this.Controls.Add(this.Label1);
            this.Name = "Sales_Reversal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales_Reversal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtproductid;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txtproductname;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtquantity;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtreceiptnumber;
        internal System.Windows.Forms.Label label4;
    }
}