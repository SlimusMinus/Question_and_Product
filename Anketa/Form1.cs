namespace Anketa
{
    public partial class Form_quest : Form
    {
        public Form_quest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            if (textBox_surname !=  null)
                str += textBox_surname.Text + "\n"; 
            if (textBox_name !=  null)
                str += textBox_name.Text + "\n";
            if (textBox_third_name !=  null)
                str += textBox_third_name.Text + "\n";
            if (textBox_age !=  null)
                str += textBox_age.Text + "\n";
            if (comboBox1 != null)
                str += comboBox1.Text + "\n";
            if (comboBox2 != null)
                str += comboBox2.Text + "\n"; 
            if (maskedTextBox1.Text != null)
                str += maskedTextBox1.Text + "\n";
            if (radioButton_man.Checked == true)
                str += radioButton_man.Text + "\n";
            if (radioButton_women.Checked == true)
                str += radioButton_women.Text + "\n"; 
            if (dateTimePicker1.Text != null)
                str += dateTimePicker1.Text + "\n"; 
            MessageBox.Show(str);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox1.SelectedItem.ToString();
            if (str == "������")
            {
                comboBox2.Text = "";
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(new object[] { "������", "�����", "����", "���������", "������������" });
            }
            else if (str == "������")
            {
                comboBox2.Text = "";
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(new object[] { "������", "���������", "���������", "���������", "����" });
            }
            else if (str == "�������")
            {
                comboBox2.Text = "";
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(new object[] { "�����", "�������", "����", "������", "�����" });
            }
            else if (str == "��������")
            {
                comboBox2.Text = "";
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(new object[] { "������", "�������", "������", "ʸ���", "��������" });
            }
            else if (str == "�������")
            {
                comboBox2.Text = "";
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(new object[] { "������", "���������", "��������", "�������", "������" });
            }

        }

        private void radioButton_man_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton manRadioButton = (RadioButton)sender;
        }

        private void radioButton_women_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton womenRadioButton = (RadioButton)sender;
        }

        private void textBox_age_TextChanged(object sender, EventArgs e)
        {
            int age;
            try
            {
                age = Int32.Parse(textBox_age.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("�������� ������ ����� ������");
                textBox_age.Text = "";
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            int num;
            try
            {
                num = Int32.Parse(textBox_age.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("�������� ������ ����� ������");
                textBox_age.Text = "";
            }
        }
    }
}