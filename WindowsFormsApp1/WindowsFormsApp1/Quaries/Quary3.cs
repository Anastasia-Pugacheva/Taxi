using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Quaries
{
    public partial class Quary3 : Supportive
    {
        public Quary3()
        {
            InitializeComponent();
        }

        private void Quary3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркDataSet.Запрос3". При необходимости она может быть перемещена или удалена.
            this.запрос3TableAdapter.Fill(this.таксопаркDataSet.Запрос3);

        }

        private void Quary3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            for (int col = 0; col < запрос3DataGridView.ColumnCount; col++)
                for (int row = 0; row < запрос3DataGridView.RowCount - 1; row++)
                {
                    запрос3DataGridView[col, row].Style.BackColor = Color.White;
                    if (запрос3DataGridView[col, row].Value.ToString().IndexOf(toolStripTextBox1.Text) >= 0) запрос3DataGridView[col, row].Style.BackColor = Color.Red;
                }
        }
    }
}
