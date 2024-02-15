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
    public partial class Trips : Supportive
    {
        public Trips()
        {
            InitializeComponent();
        }

        private void поездкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поездкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.таксопаркDataSet);

        }

        private void Trips_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркDataSet.Комфорт". При необходимости она может быть перемещена или удалена.
            this.комфортTableAdapter.Fill(this.таксопаркDataSet.Комфорт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "таксопаркDataSet.Поездки". При необходимости она может быть перемещена или удалена.
            this.поездкиTableAdapter.Fill(this.таксопаркDataSet.Поездки);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Trips_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            for (int col =0; col<поездкиDataGridView.ColumnCount; col++)
                for (int row = 0; row< поездкиDataGridView.RowCount-1;row++)
                {
                    поездкиDataGridView[col, row].Style.BackColor = Color.White;
                    if (поездкиDataGridView[col, row].Value.ToString().IndexOf(toolStripTextBox1.Text) >= 0) поездкиDataGridView[col, row].Style.BackColor = Color.Red;
                }
            
        }
    }
}
