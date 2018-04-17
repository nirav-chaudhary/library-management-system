﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_management_System_1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fm = new Form2();
            fm.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;user=root;password=nick@12345;database=test");
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from student", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            studentdataGridView.DataSource = dt;
        }
    }
}
