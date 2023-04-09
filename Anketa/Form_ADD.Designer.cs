namespace Anketa
{
    partial class Form_ADD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            comboBox_comod=new ComboBox();
            textBox_weight=new TextBox();
            textBox_Price=new TextBox();
            button_add_com=new Button();
            comboBox_country=new ComboBox();
            textBox_ALLprice=new TextBox();
            label5=new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location=new Point(34, 57);
            label1.Name="label1";
            label1.Size=new Size(110, 23);
            label1.TabIndex=0;
            label1.Text="Товар";
            // 
            // label2
            // 
            label2.Location=new Point(34, 140);
            label2.Name="label2";
            label2.Size=new Size(110, 23);
            label2.TabIndex=1;
            label2.Text="Цена";
            // 
            // label3
            // 
            label3.Location=new Point(34, 183);
            label3.Name="label3";
            label3.Size=new Size(110, 23);
            label3.TabIndex=2;
            label3.Text="Вес";
            // 
            // label4
            // 
            label4.Location=new Point(34, 101);
            label4.Name="label4";
            label4.Size=new Size(110, 23);
            label4.TabIndex=3;
            label4.Text="Страна";
            // 
            // comboBox_comod
            // 
            comboBox_comod.FormattingEnabled=true;
            comboBox_comod.Items.AddRange(new object[] { "Томаты", "Капуста", "Брокколи", "Огурцы", "Бананы", "Яблоки" });
            comboBox_comod.Location=new Point(150, 57);
            comboBox_comod.Name="comboBox_comod";
            comboBox_comod.Size=new Size(190, 23);
            comboBox_comod.TabIndex=4;
            comboBox_comod.SelectedIndexChanged+=comboBox_comod_SelectedIndexChanged;
            // 
            // textBox_weight
            // 
            textBox_weight.Location=new Point(150, 183);
            textBox_weight.Name="textBox_weight";
            textBox_weight.Size=new Size(190, 23);
            textBox_weight.TabIndex=6;
            textBox_weight.TextChanged+=textBox_weight_TextChanged;
            // 
            // textBox_Price
            // 
            textBox_Price.Location=new Point(150, 140);
            textBox_Price.Name="textBox_Price";
            textBox_Price.Size=new Size(190, 23);
            textBox_Price.TabIndex=7;
            // 
            // button_add_com
            // 
            button_add_com.BackColor=Color.White;
            button_add_com.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_add_com.Location=new Point(34, 269);
            button_add_com.Name="button_add_com";
            button_add_com.Size=new Size(306, 23);
            button_add_com.TabIndex=8;
            button_add_com.Text="OK";
            button_add_com.UseVisualStyleBackColor=false;
            button_add_com.Click+=button_add_com_Click;
            // 
            // comboBox_country
            // 
            comboBox_country.FormattingEnabled=true;
            comboBox_country.Items.AddRange(new object[] { "Россия", "Казахстан", "Узбекистан", "Китай", "Турция" });
            comboBox_country.Location=new Point(150, 101);
            comboBox_country.Name="comboBox_country";
            comboBox_country.Size=new Size(190, 23);
            comboBox_country.TabIndex=9;
            // 
            // textBox_ALLprice
            // 
            textBox_ALLprice.Location=new Point(150, 230);
            textBox_ALLprice.Name="textBox_ALLprice";
            textBox_ALLprice.Size=new Size(190, 23);
            textBox_ALLprice.TabIndex=11;
            // 
            // label5
            // 
            label5.Location=new Point(34, 230);
            label5.Name="label5";
            label5.Size=new Size(110, 23);
            label5.TabIndex=10;
            label5.Text="Общая стоимость";
            // 
            // Form_ADD
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.DarkGray;
            ClientSize=new Size(376, 341);
            Controls.Add(textBox_ALLprice);
            Controls.Add(label5);
            Controls.Add(comboBox_country);
            Controls.Add(button_add_com);
            Controls.Add(textBox_Price);
            Controls.Add(textBox_weight);
            Controls.Add(comboBox_comod);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            Name="Form_ADD";
            Text="Добавление товара";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox_comod;
        private TextBox textBox_weight;
        private TextBox textBox_Price;
        private Button button_add_com;
        private ComboBox comboBox_country;
        private TextBox textBox_ALLprice;
        private Label label5;
    }
}