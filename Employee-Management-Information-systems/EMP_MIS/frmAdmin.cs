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
    public partial class frmAdmin : Form
    {
        SqlCeConnection con_admin_panel;
        SqlCeCommand cmd_admin_panel;
        SqlCeDataAdapter da_admin_panel;
        DataSet ds_admin_panel;
        string str_admin_panel;

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            con_admin_panel = new SqlCeConnection(@"Data Source=emp_mis.sdf");
            con_admin_panel.Open();

            str_admin_panel = "SELECT * FROM emp";

            cmd_admin_panel = new SqlCeCommand(str_admin_panel,con_admin_panel);
            da_admin_panel = new SqlCeDataAdapter(cmd_admin_panel);

            ds_admin_panel = new DataSet();
            da_admin_panel.Fill(ds_admin_panel,"emp");
            this.dataGridView1.DataSource = ds_admin_panel.Tables[0];


        }

        private void createNewEmployeeRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new_employee_data objNewEmp = new new_employee_data();
            //objNewEmp.MdiParent = this;
            //objNewEmp.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
