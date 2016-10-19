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
    public partial class MainPanel : Form
    {
        SqlCeCommand cmd;
        SqlCeConnection con;
        string str;
        DataSet ds;
        SqlCeDataAdapter da;
        public MainPanel(string myId, MyRights myRights)
        {
            InitializeComponent();
            
            this.MyId = myId;
            this.MyRights = myRights; // Storing Id and admin/employee Information
        }

        public MainPanel()
        {
        }

        public MyRights MyRights { get; set; }
        public string MyId = "";

       

        private void MainPanel_Load(object sender, EventArgs e)
        {
            BackgroundColor(); // To Change Background Color of Parent Form


            frmLogin obj_login = new frmLogin();
            if(this.MyRights == EMP_MIS.MyRights.emp)
            {
                adminToolStripMenuItem.Visible = false;
                str = "select ephoto,ename from emp where eid=" + MyId;
                DisplayPicAndName();
            }
            else
            {
                employeeToolStripMenuItem.Visible = false;
                str = "select photo,uname from admin where aid=" + MyId;
                DisplayPicAndName();
            }
            
        }

        private void BackgroundColor()
        {
            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = Color.LightSkyBlue;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                    //       MessageBox.Show(exc.ToString());
                }

            }
        }


        public void HidePanel()  // To Hide User Information after Opening Child form
        {
            this.panel1.Visible = false;
        }


        public void DisplayPanel() // To Display User Information after closing Child form
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
        }


        private void DisplayPicAndName() // Method To Display User Picture and Name 
        {
            con = new SqlCeConnection(@"Data Source=emp_mis.sdf");
            con.Open();
            //str = "select ephoto,ename from emp where eid=" + MyId;
            cmd = new SqlCeCommand(str, con);
            da = new SqlCeDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "emp");
            string file_name = ds.Tables[0].Rows[0][0].ToString();
            this.pictureBox1.Image = Image.FromFile(@"emp_images\" + file_name);
            this.label1.Text = "Welcome " + ds.Tables[0].Rows[0][1].ToString();
        }


        /* Admin Menu Started */
        private void employeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            empdetails EmployeeDetails = new empdetails(this);
            EmployeeDetails.Show();
            EmployeeDetails.MdiParent = this;
            HidePanel();

        }

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new_employee_data new_employee_form = new new_employee_data(this);
            new_employee_form.Show();
            new_employee_form.MdiParent = this;
            HidePanel();
        }

        private void departmentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dept_frm df = new dept_frm();
            df.Show();
            df.MdiParent = this;
            HidePanel();
        }

        /* Admin Menu Ended */


        /* Employee Menu Started */
        private void workReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employee_report obj_employee_report = new employee_report(MyId);
            obj_employee_report.Show();
            obj_employee_report.MdiParent = this;
            HidePanel();
        }

        private void leaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            emp_leave open_emp_leave_window = new emp_leave(MyId, ds.Tables[0].Rows[0][1].ToString());
            open_emp_leave_window.Show();
            open_emp_leave_window.MdiParent = this;
            HidePanel();
        }

        /* Employee Menu Ended */
        private void MainPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

    public enum MyRights
    {
        admin,
        emp
    }
}
