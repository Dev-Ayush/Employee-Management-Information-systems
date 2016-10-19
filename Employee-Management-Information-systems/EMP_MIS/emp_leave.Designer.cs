namespace EMP_MIS
{
    partial class emp_leave
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbl_leave_name = new System.Windows.Forms.Label();
            this.txt_leave_name = new System.Windows.Forms.TextBox();
            this.lbl_leave_Date = new System.Windows.Forms.Label();
            this.txt_leave_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_leave_reason = new System.Windows.Forms.Label();
            this.txt_leave_reason = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(0, 307);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(462, 156);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_leave_name
            // 
            this.lbl_leave_name.AutoSize = true;
            this.lbl_leave_name.Location = new System.Drawing.Point(77, 25);
            this.lbl_leave_name.Name = "lbl_leave_name";
            this.lbl_leave_name.Size = new System.Drawing.Size(41, 13);
            this.lbl_leave_name.TabIndex = 1;
            this.lbl_leave_name.Text = "Name: ";
            // 
            // txt_leave_name
            // 
            this.txt_leave_name.Location = new System.Drawing.Point(174, 22);
            this.txt_leave_name.Name = "txt_leave_name";
            this.txt_leave_name.ReadOnly = true;
            this.txt_leave_name.Size = new System.Drawing.Size(200, 20);
            this.txt_leave_name.TabIndex = 2;
            // 
            // lbl_leave_Date
            // 
            this.lbl_leave_Date.AutoSize = true;
            this.lbl_leave_Date.Location = new System.Drawing.Point(77, 87);
            this.lbl_leave_Date.Name = "lbl_leave_Date";
            this.lbl_leave_Date.Size = new System.Drawing.Size(69, 13);
            this.lbl_leave_Date.TabIndex = 3;
            this.lbl_leave_Date.Text = "Select Date: ";
            // 
            // txt_leave_date
            // 
            this.txt_leave_date.Location = new System.Drawing.Point(174, 81);
            this.txt_leave_date.Name = "txt_leave_date";
            this.txt_leave_date.Size = new System.Drawing.Size(200, 20);
            this.txt_leave_date.TabIndex = 4;
            // 
            // lbl_leave_reason
            // 
            this.lbl_leave_reason.AutoSize = true;
            this.lbl_leave_reason.Location = new System.Drawing.Point(77, 144);
            this.lbl_leave_reason.Name = "lbl_leave_reason";
            this.lbl_leave_reason.Size = new System.Drawing.Size(44, 13);
            this.lbl_leave_reason.TabIndex = 5;
            this.lbl_leave_reason.Text = "Reason";
            // 
            // txt_leave_reason
            // 
            this.txt_leave_reason.Location = new System.Drawing.Point(174, 144);
            this.txt_leave_reason.Multiline = true;
            this.txt_leave_reason.Name = "txt_leave_reason";
            this.txt_leave_reason.Size = new System.Drawing.Size(200, 86);
            this.txt_leave_reason.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // emp_leave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(462, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_leave_reason);
            this.Controls.Add(this.lbl_leave_reason);
            this.Controls.Add(this.txt_leave_date);
            this.Controls.Add(this.lbl_leave_Date);
            this.Controls.Add(this.txt_leave_name);
            this.Controls.Add(this.lbl_leave_name);
            this.Controls.Add(this.listView1);
            this.Name = "emp_leave";
            this.Text = "Leave Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.emp_leave_FormClosed);
            this.Load += new System.EventHandler(this.emp_leave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbl_leave_name;
        private System.Windows.Forms.TextBox txt_leave_name;
        private System.Windows.Forms.Label lbl_leave_Date;
        private System.Windows.Forms.DateTimePicker txt_leave_date;
        private System.Windows.Forms.Label lbl_leave_reason;
        private System.Windows.Forms.TextBox txt_leave_reason;
        private System.Windows.Forms.Button button1;
    }
}