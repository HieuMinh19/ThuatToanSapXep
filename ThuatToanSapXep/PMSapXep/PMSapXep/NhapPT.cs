﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMSapXep
{
    public partial class NhapPT : Form
    {
        public NhapPT()
        {
            InitializeComponent();
        }

        private void lb_nhap_Click(object sender, EventArgs e)
        {

        }

        private void txt_Vitri_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Giatri_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(txt_Vitri);
            }
            catch
            {
                MessageBox.Show("chỉ số phần tử không hợp lệ");
                return;
            }
        }

        private void btn_exits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
