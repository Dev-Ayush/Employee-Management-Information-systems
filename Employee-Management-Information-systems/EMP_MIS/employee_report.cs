using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace EMP_MIS
{
    public partial class employee_report : Form
    {
        SqlCeConnection employee_report_con;
        SqlCeCommand employee_report_cmd;
        string employee_report_str;
        frmLogin fl;
        string MyIdd = "";
        float total_duration ;
        public employee_report(string myid)
        {
            InitializeComponent();
            this.MyIdd = myid;
            
        }

        private void employee_report_Load(object sender, EventArgs e)
        {
            fl = new frmLogin();
            this.employee_report_id.Text = MyIdd.ToString();

            //this.employee_report_id.Text = fl.textBox1.Text;
            this.employee_report__current_date.Text = DateTime.Now.ToString("MM/dd/yyyy");
            
            employee_report_in_time.Format = DateTimePickerFormat.Time;
            employee_report_in_time.ShowUpDown = true;

            employee_report_out_time.Format = DateTimePickerFormat.Time;
            employee_report_out_time.ShowUpDown = true;

            this.lbl_employee_report_duration.Visible = false;
            this.employee_report__duration.Visible = false;

        }

        private void employee_report_in_time_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employee_report_con = new SqlCeConnection(@"Data Source=emp_mis.sdf");
            employee_report_con.Open();
            
            employee_report_str = "insert into works values("+Convert.ToInt32(this.employee_report_id.Text)+",'"+Convert.ToDateTime(this.employee_report__current_date.Text)+"','"+Convert.ToDateTime(this.employee_report_in_time.Text)+"','"+Convert.ToDateTime(this.employee_report_out_time.Text)+"','"+this.employee_report_work_report.Text+"',"+total_duration+")";
            employee_report_cmd = new SqlCeCommand(employee_report_str, employee_report_con);
            employee_report_cmd.ExecuteNonQuery();
            employee_report_con.Close();
            MessageBox.Show("Successfully Submitted");
            this.Close();
        }
        
        private void employee_report_out_time_Leave(object sender, EventArgs e)
        {
            if (this.employee_report_in_time.Value != null && this.employee_report_out_time.Value != null)
            {

                TimeSpan ts = (employee_report_out_time.Value - employee_report_in_time.Value);
                float res_hrs = Math.Abs(ts.Hours);
                float res_min = Math.Abs(ts.Minutes);
                float res_sec = Math.Abs(ts.Seconds);
                string display_duration = res_hrs.ToString() + " Hours : " + res_min.ToString() + " Minutes : " + res_sec.ToString() + " Seconds";
                string temp_value = res_hrs.ToString() + "." + res_min.ToString();
                total_duration = Math.Abs(float.Parse(temp_value));
                this.lbl_employee_report_duration.Visible = true;
                this.employee_report__duration.Visible = true;
                employee_report__duration.Text = display_duration;
             }
        }

        private void employee_report_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((MainPanel)MdiParent).DisplayPanel();
        }
        private void employee_report__current_date_Click(object sender, EventArgs e)
        {

        }

        private void employee_report_out_time_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void employee_report__duration_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
