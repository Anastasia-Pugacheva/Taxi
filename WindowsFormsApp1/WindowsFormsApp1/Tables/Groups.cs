using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Tables
{
    public partial class Groups : Supportive
    {
        public Groups()
        {
            InitializeComponent();
        }

        private void группы_услугBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.группы_услугBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.таксопаркDataSet);

        }

        private void Groups_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркDataSet.Группы_услуг". При необходимости она может быть перемещена или удалена.
            this.группы_услугTableAdapter.Fill(this.таксопаркDataSet.Группы_услуг);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Groups_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            for (int col = 0; col < группы_услугDataGridView.ColumnCount; col++)
                for (int row = 0; row < группы_услугDataGridView.RowCount - 1; row++)
                {
                    группы_услугDataGridView[col, row].Style.BackColor = Color.White;
                    if (группы_услугDataGridView[col, row].Value.ToString().IndexOf(toolStripTextBox1.Text) >= 0) группы_услугDataGridView[col, row].Style.BackColor = Color.Red;
                }
        }
    }
}
