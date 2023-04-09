using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anketa
{
    public partial class Quest_and_Product : Form
    {
        public Quest_and_Product()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_quest form_Quest = new Form_quest();
            form_Quest.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ShowDialog();
        }
    }
}
