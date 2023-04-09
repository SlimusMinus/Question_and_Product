using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Serialization;


namespace Anketa
{
    public partial class Product : Form
    {
        XmlSerializer xs = new XmlSerializer(typeof(Comodity)); 
        public double fin_price;
        Comodity comodity = new Comodity();
        public Product()
        {
            InitializeComponent();
            listBox1.Items.Add("|     Товар     | Страна производитель | Цена за 1 кг | Вес | Общая стоимость |\n");
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            Form_ADD form_ADD = new Form_ADD();
            if (form_ADD.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(form_ADD.comod);
                fin_price += form_ADD.finish_price_comod;
            }
            using (Stream fs = File.Create("product.xml"))
            {
                xs.Serialize(fs, form_ADD.comod);
            }
        }

        private void bt_Dell_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private ListBox GetListBox1()
        {
            return listBox1;
        }

        private void button_red_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            Form_ADD form_ADD = new Form_ADD();
            comodity = (Comodity)listBox1.Items[i];
            form_ADD.Names = comodity.name;
            form_ADD.Country = comodity.country;
            form_ADD.Weight = comodity.weight;
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            if (form_ADD.ShowDialog() == DialogResult.OK)
                listBox1.Items.Add(form_ADD.comod);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_ADD form_ADD = new Form_ADD();

            string str = fin_price.ToString();
            MessageBox.Show(str);
        }
    }
}
