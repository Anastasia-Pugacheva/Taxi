using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
             
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection;
            OleDbCommand command;
            OleDbDataReader reader;

            string log = textBox1.Text;
            string pass = textBox2.Text;

            string connectStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cv22\source\repos\WindowsFormsApp1\WindowsFormsApp1\Таксопарк.accdb";
            string quary = $"select * from Вход where Логин = '{log}' and Пароль = '{pass}'";

            connection = new OleDbConnection(connectStr);
            connection.Open();

            command = new OleDbCommand(quary, connection);
            reader= command.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Добро пожаловать");
               Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            connection.Close();

        }

       
        
    }
}
