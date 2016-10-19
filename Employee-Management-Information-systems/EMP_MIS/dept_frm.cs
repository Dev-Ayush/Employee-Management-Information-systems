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
    public partial class dept_frm : Form
    {
        db_connection ob;
        public dept_frm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ob = new db_connection();
            string s = "insert into department(department) values('"+ this.textBox1.Text +"')";
            try
            {

                ob.iud(s);
                MessageBox.Show("Submitted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex.ToString());
            }

            s = "select * from department";
            this.dataGridView1.DataSource = ob.rs(s).Tables[0];
        }

        private void dept_frm_Load(object sender, EventArgs e)
        {

        }

        private void dept_frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //((MainPanel)this.MdiParent).DisplayPanel();
            ((MainPanel)this.MdiParent).DisplayPanel();
        }
    }
}
