namespace Anketa
{
    partial class Form_quest
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_quest));
            button1=new Button();
            dateTimePicker1=new DateTimePicker();
            label2=new Label();
            radioButton_women=new RadioButton();
            radioButton_man=new RadioButton();
            label1=new Label();
            label_number=new Label();
            comboBox2=new ComboBox();
            label_city=new Label();
            comboBox1=new ComboBox();
            label_country=new Label();
            textBox_age=new TextBox();
            label_age=new Label();
            textBox_surname=new TextBox();
            textBox_third_name=new TextBox();
            textBox_name=new TextBox();
            label_fath_name=new Label();
            label_name=new Label();
            label_surname=new Label();
            groupBox1=new GroupBox();
            maskedTextBox1=new MaskedTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor=Color.Moccasin;
            button1.Font=new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location=new Point(37, 469);
            button1.Name="button1";
            button1.Size=new Size(392, 35);
            button1.TabIndex=3;
            button1.Text="Результат заполнения";
            button1.UseVisualStyleBackColor=false;
            button1.Click+=button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location=new Point(174, 341);
            dateTimePicker1.Name="dateTimePicker1";
            dateTimePicker1.Size=new Size(200, 27);
            dateTimePicker1.TabIndex=18;
            // 
            // label2
            // 
            label2.BackColor=SystemColors.InactiveCaption;
            label2.Font=new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(33, 341);
            label2.Name="label2";
            label2.Size=new Size(117, 27);
            label2.TabIndex=17;
            label2.Text="Дата рождения";
            label2.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // radioButton_women
            // 
            radioButton_women.AutoSize=true;
            radioButton_women.Location=new Point(270, 382);
            radioButton_women.Name="radioButton_women";
            radioButton_women.Size=new Size(87, 24);
            radioButton_women.TabIndex=16;
            radioButton_women.TabStop=true;
            radioButton_women.Text="женский";
            radioButton_women.UseVisualStyleBackColor=true;
            radioButton_women.CheckedChanged+=radioButton_women_CheckedChanged;
            // 
            // radioButton_man
            // 
            radioButton_man.AutoSize=true;
            radioButton_man.Location=new Point(174, 382);
            radioButton_man.Name="radioButton_man";
            radioButton_man.Size=new Size(88, 24);
            radioButton_man.TabIndex=15;
            radioButton_man.TabStop=true;
            radioButton_man.Text="мужской";
            radioButton_man.UseVisualStyleBackColor=true;
            radioButton_man.CheckedChanged+=radioButton_man_CheckedChanged;
            // 
            // label1
            // 
            label1.BackColor=SystemColors.InactiveCaption;
            label1.Font=new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(33, 379);
            label1.Name="label1";
            label1.Size=new Size(87, 27);
            label1.TabIndex=14;
            label1.Text="Пол";
            label1.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // label_number
            // 
            label_number.BackColor=SystemColors.InactiveCaption;
            label_number.Font=new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_number.Location=new Point(33, 303);
            label_number.Name="label_number";
            label_number.Size=new Size(87, 27);
            label_number.TabIndex=12;
            label_number.Text="Телефон";
            label_number.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled=true;
            comboBox2.Location=new Point(174, 257);
            comboBox2.Name="comboBox2";
            comboBox2.Size=new Size(200, 28);
            comboBox2.TabIndex=11;
            // 
            // label_city
            // 
            label_city.BackColor=SystemColors.InactiveCaption;
            label_city.Font=new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_city.Location=new Point(33, 257);
            label_city.Name="label_city";
            label_city.Size=new Size(87, 28);
            label_city.TabIndex=10;
            label_city.Text="Город";
            label_city.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled=true;
            comboBox1.Items.AddRange(new object[] { "Россия", "Англия", "Франция", "Германия", "Испания" });
            comboBox1.Location=new Point(174, 215);
            comboBox1.Name="comboBox1";
            comboBox1.Size=new Size(200, 28);
            comboBox1.TabIndex=9;
            comboBox1.SelectedIndexChanged+=comboBox1_SelectedIndexChanged;
            // 
            // label_country
            // 
            label_country.BackColor=SystemColors.InactiveCaption;
            label_country.Font=new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_country.Location=new Point(33, 215);
            label_country.Name="label_country";
            label_country.Size=new Size(87, 28);
            label_country.TabIndex=8;
            label_country.Text="Страна";
            label_country.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // textBox_age
            // 
            textBox_age.Location=new Point(174, 171);
            textBox_age.Name="textBox_age";
            textBox_age.Size=new Size(200, 27);
            textBox_age.TabIndex=7;
            textBox_age.TextChanged+=textBox_age_TextChanged;
            // 
            // label_age
            // 
            label_age.BackColor=SystemColors.InactiveCaption;
            label_age.Font=new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_age.Location=new Point(33, 171);
            label_age.Name="label_age";
            label_age.Size=new Size(87, 27);
            label_age.TabIndex=6;
            label_age.Text="Возраст";
            label_age.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // textBox_surname
            // 
            textBox_surname.Location=new Point(175, 56);
            textBox_surname.Name="textBox_surname";
            textBox_surname.Size=new Size(200, 27);
            textBox_surname.TabIndex=5;
            // 
            // textBox_third_name
            // 
            textBox_third_name.Location=new Point(174, 133);
            textBox_third_name.Name="textBox_third_name";
            textBox_third_name.Size=new Size(200, 27);
            textBox_third_name.TabIndex=4;
            // 
            // textBox_name
            // 
            textBox_name.Location=new Point(174, 94);
            textBox_name.Name="textBox_name";
            textBox_name.Size=new Size(200, 27);
            textBox_name.TabIndex=3;
            // 
            // label_fath_name
            // 
            label_fath_name.BackColor=SystemColors.InactiveCaption;
            label_fath_name.Font=new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_fath_name.Location=new Point(33, 133);
            label_fath_name.Name="label_fath_name";
            label_fath_name.Size=new Size(87, 27);
            label_fath_name.TabIndex=2;
            label_fath_name.Text="Отчество";
            label_fath_name.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // label_name
            // 
            label_name.BackColor=SystemColors.InactiveCaption;
            label_name.Font=new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_name.Location=new Point(33, 94);
            label_name.Name="label_name";
            label_name.Size=new Size(87, 27);
            label_name.TabIndex=1;
            label_name.Text="Имя";
            label_name.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // label_surname
            // 
            label_surname.BackColor=SystemColors.InactiveCaption;
            label_surname.Font=new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_surname.Location=new Point(33, 56);
            label_surname.Name="label_surname";
            label_surname.Size=new Size(87, 25);
            label_surname.TabIndex=0;
            label_surname.Text="Фамилия";
            label_surname.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.BackColor=SystemColors.InactiveCaption;
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(radioButton_women);
            groupBox1.Controls.Add(radioButton_man);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label_number);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label_city);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label_country);
            groupBox1.Controls.Add(textBox_age);
            groupBox1.Controls.Add(label_age);
            groupBox1.Controls.Add(textBox_surname);
            groupBox1.Controls.Add(textBox_third_name);
            groupBox1.Controls.Add(textBox_name);
            groupBox1.Controls.Add(label_fath_name);
            groupBox1.Controls.Add(label_name);
            groupBox1.Controls.Add(label_surname);
            groupBox1.Font=new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location=new Point(33, 22);
            groupBox1.Name="groupBox1";
            groupBox1.Size=new Size(396, 423);
            groupBox1.TabIndex=2;
            groupBox1.TabStop=false;
            groupBox1.Text="Анкета";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location=new Point(173, 303);
            maskedTextBox1.Mask="(999) 000-0000";
            maskedTextBox1.Name="maskedTextBox1";
            maskedTextBox1.Size=new Size(201, 27);
            maskedTextBox1.TabIndex=19;
            maskedTextBox1.MaskInputRejected+=maskedTextBox1_MaskInputRejected;
            // 
            // Form_quest
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.InactiveCaption;
            ClientSize=new Size(459, 537);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            Icon=(Icon)resources.GetObject("$this.Icon");
            Name="Form_quest";
            Text="Question";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private RadioButton radioButton_women;
        private RadioButton radioButton_man;
        private Label label1;
        private Label label_number;
        private ComboBox comboBox2;
        private Label label_city;
        private ComboBox comboBox1;
        private Label label_country;
        private TextBox textBox_age;
        private Label label_age;
        private TextBox textBox_surname;
        private TextBox textBox_third_name;
        private TextBox textBox_name;
        private Label label_fath_name;
        private Label label_name;
        private Label label_surname;
        private GroupBox groupBox1;
        private MaskedTextBox maskedTextBox1;
    }
}