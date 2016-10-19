using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;

namespace EMP_MIS
{
    public partial class new_employee_data : Form
    {
        SqlCeConnection con_new_employee_data;
        SqlCeCommand cmd_new_employee_data;
        SqlCeCommand cmd_new_employee_data2;
        string str_new_employee_data;
        MainPanel Mp;
        public new_employee_data(MainPanel mp)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"dummy1.jpg");
            this.txt_new_employee_data_photo_browse.Visible = false;
            this.Mp = mp;
        }

        private void txt_new_employee_data_photo_browse_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_new_employee_data_add_new_data_Click(object sender, EventArgs e)
        {
         
        }

        private void new_employee_data_Load(object sender, EventArgs e)
        {
            this.txt_new_employee_data_photo_name.Text = "";
            db_connection ob = new db_connection();
            string s = "select department from department";
           
                this.comboBox1.DataSource=ob.rs(s).Tables[0];
                comboBox1.ValueMember = "department";
        }

        private void txt_new_employee_data_add_new_data_Click_1(object sender, EventArgs e)
        {
            int available_leave_data = 14;
            int applied_leave_data = 0;
            int remaining_leave_data = 14;

            con_new_employee_data = new SqlCeConnection(@"Data Source=emp_mis.sdf");
            con_new_employee_data.Open();

            str_new_employee_data = "insert into emp(ename,epass,eaddress,egender,edesig,edoj,ephone,eemail,ephoto,eid,edept) values('" +
                this.txt_new_employee_data_name.Text +
                "','" + this.txt_new_employee_data_password.Text +
                "','" + this.txt_new_employee_data_address.Text +
                "','" + this.txt_new_employee_data_gender.GetItemText(this.txt_new_employee_data_gender.SelectedItem) +
                "','" + this.txt_new_employee_data_designation.Text +
                "','" + this.txt_new_employee_data_doj.Value.ToLongTimeString() +
                "','" + this.txt_new_employee_data_phone.Text +
                "','" + this.txt_new_employee_data_email.Text +

                "','" + Path.GetFileName(this.openFileDialog1.FileName) +
                "'," + Convert.ToInt32(this.txt_new_employee_data_id.Text) + 
                ",'" + this.comboBox1.Text + "')";
            
            string str_new_employee_data2 = "insert into leave_calculation values(" + Convert.ToInt32(this.txt_new_employee_data_id.Text) + ", " + Convert.ToInt32(available_leave_data) + ", " + Convert.ToInt32(applied_leave_data) + ", " + Convert.ToInt32(remaining_leave_data) + ")";


            cmd_new_employee_data = new SqlCeCommand(str_new_employee_data, con_new_employee_data);
            cmd_new_employee_data.ExecuteNonQuery(); // Executing to Insert Into Employee Table

            cmd_new_employee_data2 = new SqlCeCommand(str_new_employee_data2,con_new_employee_data);
            cmd_new_employee_data2.ExecuteNonQuery(); // Executing to Insert into LeaveCalculation Table

            con_new_employee_data.Close();

            File.Copy(this.openFileDialog1.FileName, Directory.GetCurrentDirectory().ToString() + "\\emp_images\\" + System.IO.Path.GetFileName(this.openFileDialog1.FileName));
            MessageBox.Show("Successfully Inserted");
            con_new_employee_data.Close();
            this.Close();
          
        }

        private void txt_new_employee_data_photo_browse_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txt_new_employee_data_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.openFileDialog1.FileName);
            MessageBox.Show(Directory.GetCurrentDirectory().ToString() + "\\emp_images\\" + System.IO.Path.GetFileName(this.openFileDialog1.FileName));
            File.Copy(this.openFileDialog1.FileName, Directory.GetCurrentDirectory().ToString() + "\\emp_images\\" + System.IO.Path.GetFileName(this.openFileDialog1.FileName));
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
           {
                this.txt_new_employee_data_photo_name.Text = System.IO.Path.GetFileName(this.openFileDialog1.FileName);
                this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
           }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void new_employee_data_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mp.DisplayPanel();
        }
    }
}
