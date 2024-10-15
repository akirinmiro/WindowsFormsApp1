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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Workers workers = new Workers();
            workers.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            All all = new All();
            all.Show();
        }
    }
}
