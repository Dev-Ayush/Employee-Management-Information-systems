namespace EMP_MIS
{
    partial class employee_report
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
            this.lbl_employee_report_id = new System.Windows.Forms.Label();
            this.employee_report_id = new System.Windows.Forms.TextBox();
            this.lbl_employee_report_current_date = new System.Windows.Forms.Label();
            this.employee_report__current_date = new System.Windows.Forms.Label();
            this.lbl_employee_report_in_time = new System.Windows.Forms.Label();
            this.lbl_employee_report_out_time = new System.Windows.Forms.Label();
            this.lbl_employee_report_work_report = new System.Windows.Forms.Label();
            this.employee_report_work_report = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.employee_report_in_time = new System.Windows.Forms.DateTimePicker();
            this.employee_report_out_time = new System.Windows.Forms.DateTimePicker();
            this.lbl_employee_report_duration = new System.Windows.Forms.Label();
            this.employee_report__duration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_employee_report_id
            // 
            this.lbl_employee_report_id.AutoSize = true;
            this.lbl_employee_report_id.Location = new System.Drawing.Point(55, 39);
            this.lbl_employee_report_id.Name = "lbl_employee_report_id";
            this.lbl_employee_report_id.Size = new System.Drawing.Size(21, 13);
            this.lbl_employee_report_id.TabIndex = 0;
            this.lbl_employee_report_id.Text = "ID:";
            // 
            // employee_report_id
            // 
            this.employee_report_id.Location = new System.Drawing.Point(151, 39);
            this.employee_report_id.Name = "employee_report_id";
            this.employee_report_id.ReadOnly = true;
            this.employee_report_id.Size = new System.Drawing.Size(156, 20);
            this.employee_report_id.TabIndex = 1;
            // 
            // lbl_employee_report_current_date
            // 
            this.lbl_employee_report_current_date.AutoSize = true;
            this.lbl_employee_report_current_date.Location = new System.Drawing.Point(374, 39);
            this.lbl_employee_report_current_date.Name = "lbl_employee_report_current_date";
            this.lbl_employee_report_current_date.Size = new System.Drawing.Size(73, 13);
            this.lbl_employee_report_current_date.TabIndex = 2;
            this.lbl_employee_report_current_date.Text = "Today\'s Date:";
            // 
            // employee_report__current_date
            // 
            this.employee_report__current_date.AutoSize = true;
            this.employee_report__current_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_report__current_date.Location = new System.Drawing.Point(481, 39);
            this.employee_report__current_date.Name = "employee_report__current_date";
            this.employee_report__current_date.Size = new System.Drawing.Size(51, 20);
            this.employee_report__current_date.TabIndex = 3;
            this.employee_report__current_date.Text = "label3";
            this.employee_report__current_date.Click += new System.EventHandler(this.employee_report__current_date_Click);
            // 
            // lbl_employee_report_in_time
            // 
            this.lbl_employee_report_in_time.AutoSize = true;
            this.lbl_employee_report_in_time.Location = new System.Drawing.Point(55, 99);
            this.lbl_employee_report_in_time.Name = "lbl_employee_report_in_time";
            this.lbl_employee_report_in_time.Size = new System.Drawing.Size(54, 13);
            this.lbl_employee_report_in_time.TabIndex = 4;
            this.lbl_employee_report_in_time.Text = "In - Time :";
            // 
            // lbl_employee_report_out_time
            // 
            this.lbl_employee_report_out_time.AutoSize = true;
            this.lbl_employee_report_out_time.Location = new System.Drawing.Point(374, 99);
            this.lbl_employee_report_out_time.Name = "lbl_employee_report_out_time";
            this.lbl_employee_report_out_time.Size = new System.Drawing.Size(62, 13);
            this.lbl_employee_report_out_time.TabIndex = 5;
            this.lbl_employee_report_out_time.Text = "Out - Time :";
            // 
            // lbl_employee_report_work_report
            // 
            this.lbl_employee_report_work_report.AutoSize = true;
            this.lbl_employee_report_work_report.Location = new System.Drawing.Point(55, 173);
            this.lbl_employee_report_work_report.Name = "lbl_employee_report_work_report";
            this.lbl_employee_report_work_report.Size = new System.Drawing.Size(74, 13);
            this.lbl_employee_report_work_report.TabIndex = 6;
            this.lbl_employee_report_work_report.Text = "Work Report: ";
            // 
            // employee_report_work_report
            // 
            this.employee_report_work_report.Location = new System.Drawing.Point(151, 173);
            this.employee_report_work_report.Multiline = true;
            this.employee_report_work_report.Name = "employee_report_work_report";
            this.employee_report_work_report.Size = new System.Drawing.Size(200, 90);
            this.employee_report_work_report.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // employee_report_in_time
            // 
            this.employee_report_in_time.Location = new System.Drawing.Point(151, 99);
            this.employee_report_in_time.Name = "employee_report_in_time";
            this.employee_report_in_time.Size = new System.Drawing.Size(200, 20);
            this.employee_report_in_time.TabIndex = 9;
            this.employee_report_in_time.ValueChanged += new System.EventHandler(this.employee_report_in_time_ValueChanged);
            // 
            // employee_report_out_time
            // 
            this.employee_report_out_time.Location = new System.Drawing.Point(476, 99);
            this.employee_report_out_time.Name = "employee_report_out_time";
            this.employee_report_out_time.Size = new System.Drawing.Size(200, 20);
            this.employee_report_out_time.TabIndex = 10;
            this.employee_report_out_time.ValueChanged += new System.EventHandler(this.employee_report_out_time_ValueChanged);
            this.employee_report_out_time.Leave += new System.EventHandler(this.employee_report_out_time_Leave);
            // 
            // lbl_employee_report_duration
            // 
            this.lbl_employee_report_duration.AutoSize = true;
            this.lbl_employee_report_duration.Location = new System.Drawing.Point(55, 293);
            this.lbl_employee_report_duration.Name = "lbl_employee_report_duration";
            this.lbl_employee_report_duration.Size = new System.Drawing.Size(53, 13);
            this.lbl_employee_report_duration.TabIndex = 11;
            this.lbl_employee_report_duration.Text = "Duration: ";
            // 
            // employee_report__duration
            // 
            this.employee_report__duration.AutoSize = true;
            this.employee_report__duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_report__duration.Location = new System.Drawing.Point(147, 293);
            this.employee_report__duration.Name = "employee_report__duration";
            this.employee_report__duration.Size = new System.Drawing.Size(51, 20);
            this.employee_report__duration.TabIndex = 12;
            this.employee_report__duration.Text = "label1";
            this.employee_report__duration.Click += new System.EventHandler(this.employee_report__duration_Click);
            // 
            // employee_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(688, 328);
            this.Controls.Add(this.employee_report__duration);
            this.Controls.Add(this.lbl_employee_report_duration);
            this.Controls.Add(this.employee_report_out_time);
            this.Controls.Add(this.employee_report_in_time);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.employee_report_work_report);
            this.Controls.Add(this.lbl_employee_report_work_report);
            this.Controls.Add(this.lbl_employee_report_out_time);
            this.Controls.Add(this.lbl_employee_report_in_time);
            this.Controls.Add(this.employee_report__current_date);
            this.Controls.Add(this.lbl_employee_report_current_date);
            this.Controls.Add(this.employee_report_id);
            this.Controls.Add(this.lbl_employee_report_id);
            this.Name = "employee_report";
            this.Text = "employee_report";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.employee_report_FormClosed);
            this.Load += new System.EventHandler(this.employee_report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_employee_report_id;
        private System.Windows.Forms.TextBox employee_report_id;
        private System.Windows.Forms.Label lbl_employee_report_current_date;
        private System.Windows.Forms.Label employee_report__current_date;
        private System.Windows.Forms.Label lbl_employee_report_in_time;
        private System.Windows.Forms.Label lbl_employee_report_out_time;
        private System.Windows.Forms.Label lbl_employee_report_work_report;
        private System.Windows.Forms.TextBox employee_report_work_report;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker employee_report_in_time;
        private System.Windows.Forms.DateTimePicker employee_report_out_time;
        private System.Windows.Forms.Label lbl_employee_report_duration;
        private System.Windows.Forms.Label employee_report__duration;
    }
}