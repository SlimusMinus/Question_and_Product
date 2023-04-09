namespace Anketa
{
    partial class Product
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
            bt_Add=new Button();
            bt_Dell=new Button();
            bt_Clear=new Button();
            listBox1=new ListBox();
            button_red=new Button();
            button1=new Button();
            SuspendLayout();
            // 
            // bt_Add
            // 
            bt_Add.BackColor=Color.CornflowerBlue;
            bt_Add.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Add.Location=new Point(61, 214);
            bt_Add.Name="bt_Add";
            bt_Add.Size=new Size(317, 23);
            bt_Add.TabIndex=1;
            bt_Add.Text="Добавить";
            bt_Add.UseVisualStyleBackColor=false;
            bt_Add.Click+=bt_Add_Click;
            // 
            // bt_Dell
            // 
            bt_Dell.BackColor=Color.CornflowerBlue;
            bt_Dell.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Dell.Location=new Point(61, 294);
            bt_Dell.Name="bt_Dell";
            bt_Dell.Size=new Size(317, 23);
            bt_Dell.TabIndex=3;
            bt_Dell.Text="Удалить";
            bt_Dell.UseVisualStyleBackColor=false;
            bt_Dell.Click+=bt_Dell_Click;
            // 
            // bt_Clear
            // 
            bt_Clear.BackColor=Color.CornflowerBlue;
            bt_Clear.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Clear.Location=new Point(61, 335);
            bt_Clear.Name="bt_Clear";
            bt_Clear.Size=new Size(317, 23);
            bt_Clear.TabIndex=4;
            bt_Clear.Text="Очистить";
            bt_Clear.UseVisualStyleBackColor=false;
            bt_Clear.Click+=bt_Clear_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled=true;
            listBox1.ItemHeight=15;
            listBox1.Location=new Point(12, 42);
            listBox1.Name="listBox1";
            listBox1.Size=new Size(426, 139);
            listBox1.TabIndex=5;
            // 
            // button_red
            // 
            button_red.BackColor=Color.CornflowerBlue;
            button_red.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_red.Location=new Point(61, 252);
            button_red.Name="button_red";
            button_red.Size=new Size(317, 23);
            button_red.TabIndex=7;
            button_red.Text="Редактировать";
            button_red.UseVisualStyleBackColor=false;
            button_red.Click+=button_red_Click;
            // 
            // button1
            // 
            button1.BackColor=Color.CornflowerBlue;
            button1.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location=new Point(61, 376);
            button1.Name="button1";
            button1.Size=new Size(317, 23);
            button1.TabIndex=8;
            button1.Text="Общая стоимость";
            button1.UseVisualStyleBackColor=false;
            button1.Click+=button1_Click;
            // 
            // Product
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LightYellow;
            ClientSize=new Size(452, 422);
            Controls.Add(button1);
            Controls.Add(button_red);
            Controls.Add(listBox1);
            Controls.Add(bt_Clear);
            Controls.Add(bt_Dell);
            Controls.Add(bt_Add);
            Name="Product";
            Text="Product";
            ResumeLayout(false);
        }

        #endregion
        private Button bt_Add;
        private Button bt_Dell;
        private Button bt_Clear;
        private ListBox listBox1;
        private Button button_red;
        private Button button1;
    }
}