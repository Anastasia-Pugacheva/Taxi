using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Quaries;
using WindowsFormsApp1.Tables;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Drivers drivers = new Drivers();
            drivers.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Comfort comfort = new Comfort();
            comfort.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Groups groups = new Groups();
            groups.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Trips trips = new Trips();
            trips.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Tarifs tarifs = new Tarifs();
            tarifs.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           Quary1 quary1 = new Quary1();
            quary1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Quary2 quary2 = new Quary2();
            quary2.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Quary3 quary3 = new Quary3();
            quary3.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
