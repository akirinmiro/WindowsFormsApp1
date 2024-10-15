using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class All : Form
    {
        public All()
        {
            InitializeComponent();
        }

        private void All_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storeDataSet.AllProduct". При необходимости она может быть перемещена или удалена.
            this.allProductTableAdapter.Fill(this.storeDataSet.AllProduct);

        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                string searchText = textBox1.Text;
             UpdateSearch();
        }

        private void UpdateSearch()
        {
            string searchText = textBox1.Text;
            dataGridView1.ClearSelection();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(searchText))
                    {
                        dataGridView1.Rows[row.Index].Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }
        }
    
}
