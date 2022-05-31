using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton_and_CheckBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void compute_btn_Click(object sender, EventArgs e)
        {
            double sub_total = 0;
            double discount = 0;
            double net_amount = 0;

            if (tv21_cb.Checked)
                sub_total = sub_total + 10000;
            if (tv14_cb.Checked)
                sub_total = sub_total + 7500;
            if (tv12_cb.Checked)
                sub_total = sub_total + 5000;

            if (five_rb.Checked)
                discount = sub_total * 0.05;
            if (ten_rb.Checked)
                discount = sub_total * 0.10;
            if (fifteen_rb.Checked)
                discount = sub_total * 0.15;

            net_amount = sub_total - discount;

            subtotal_txtbox.Text = sub_total.ToString("C");
            discount_txtbox.Text = discount.ToString("C");
            netamount_txtbox.Text = net_amount.ToString("C");
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            tv21_cb.Checked = false;
            tv14_cb.Checked = false;
            tv12_cb.Checked = false;
            five_rb.Checked = false;
            ten_rb.Checked = false;
            fifteen_rb.Checked = false;
            subtotal_txtbox.Clear();
            discount_txtbox.Clear();
            netamount_txtbox.Clear();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
