using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingExercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //add employee
            lbx_employee.Items.Add(txt_employee.Text);

            //add available workdays
            string workdays = "";

            if (monday.CheckState == CheckState.Checked)
            {
                workdays += "M, ";
            }
            if (tuesday.CheckState == CheckState.Checked)
            {
                workdays += "T, ";
            }
            if (wednesday.CheckState == CheckState.Checked)
            {
                workdays += "W, ";
            }
            if (thursday.CheckState == CheckState.Checked)
            {
                workdays += "Th, ";
            }
            if (friday.CheckState == CheckState.Checked)
            {
                workdays += "F, ";
            }
            if (saturday.CheckState == CheckState.Checked)
            {
                workdays += "S, ";
            }
            if (sunday.CheckState == CheckState.Checked)
            {
                workdays += "Su";
            }

            lbx_wkdays.Items.Add(workdays);

            //add shift
            
            if (rb_morning.Checked)
            {
                lbx_shift.Items.Add("Morning");
            }
            if (rb_afternoon.Checked)
            {
                lbx_shift.Items.Add("Afternoon");
            }
            if (rb_evening.Checked)
            {
                lbx_shift.Items.Add("Morning");
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lbx_employee.Items.Clear();
            lbx_wkdays.Items.Clear();
            lbx_shift.Items.Clear();
            txt_employee.Clear();
            gb_wkday.Controls.Clear();
            gb_shift.Controls.Clear();
        }
    }
}
