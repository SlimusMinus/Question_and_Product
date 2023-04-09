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

namespace Anketa
{
    public partial class Form_ADD : Form
    {
        public double finish_price_comod = 0;
        public string Names
        {
            get { return comboBox_comod.Text; }
            set { comboBox_comod.Text = value; }
        }
        public string Country
        {
            get { return comboBox_country.Text; }
            set { comboBox_country.Text = value; }
        }
        public string Price
        {
            get { return textBox_Price.Text; }
            set { textBox_Price.Text = value; }
        }
        public string Weight
        {
            get { return textBox_weight.Text; }
            set { textBox_weight.Text = value; }

        }
        public string ALLprice
        {
            get { return textBox_ALLprice.Text; }
            set { textBox_ALLprice.Text = value; }
        }

        public Comodity comod
        {
            get
            {
                Comodity comods = new Comodity(comboBox_comod.Text, comboBox_country.Text, textBox_Price.Text, textBox_weight.Text, textBox_ALLprice.Text);
                return comods;
            }
        }

        public Form_ADD()
        {
            InitializeComponent();
        }

        private void button_add_com_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void comboBox_comod_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox_comod.SelectedItem.ToString();
            if (str == "Томаты")
                textBox_Price.Text = "150";
            else if (str == "Капуста")
                textBox_Price.Text = "135";
            else if (str == "Брокколи")
                textBox_Price.Text = "220";
            else if (str == "Огурцы")
                textBox_Price.Text = "155";
            else if (str == "Бананы")
                textBox_Price.Text = "90";
            else if (str == "Яблоки")
                textBox_Price.Text = "112";
        }

        private void textBox_weight_TextChanged(object sender, EventArgs e)
        {
            Product product = new Product();
            string str = comboBox_country.SelectedItem.ToString();
            double price = Double.Parse(textBox_Price.Text);
            double weight = Double.Parse(textBox_weight.Text);
            if (str == "Россия")
                price *= (1.2*weight);
            else if (str == "Казахстан")
                price *= (1.7*weight);
            else if (str == "Узбекистан")
                price *= (1.5*weight);
            else if (str == "Китай")
                price *= (2.5*weight);
            else if (str == "Турция")
                price *= (2*weight);
            finish_price_comod += price;
            textBox_ALLprice.Text = price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;

        }
    }
}
