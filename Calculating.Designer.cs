
namespace Kursach
{
    partial class Calculating
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cnlbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.okbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cnlbtn);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.okbtn);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(281, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расчет";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Расчет:";
            // 
            // cnlbtn
            // 
            this.cnlbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cnlbtn.Location = new System.Drawing.Point(146, 305);
            this.cnlbtn.Margin = new System.Windows.Forms.Padding(2);
            this.cnlbtn.Name = "cnlbtn";
            this.cnlbtn.Size = new System.Drawing.Size(128, 30);
            this.cnlbtn.TabIndex = 1;
            this.cnlbtn.Text = "Отмена";
            this.cnlbtn.UseVisualStyleBackColor = true;
            this.cnlbtn.Click += new System.EventHandler(this.cnlbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Материал";
            // 
            // okbtn
            // 
            this.okbtn.Location = new System.Drawing.Point(6, 305);
            this.okbtn.Margin = new System.Windows.Forms.Padding(2);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(136, 30);
            this.okbtn.TabIndex = 0;
            this.okbtn.Text = "Расчитать";
            this.okbtn.UseVisualStyleBackColor = true;
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Категория";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Помещение";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите помещение, а затем категорию для подсчета необходимого количества матери" +
    "алов";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 69);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(269, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 259);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(5, 124);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(269, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(5, 178);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(269, 21);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(289, 369);
            this.tabControl1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 218);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 40);
            this.label6.TabIndex = 12;
            this.label6.Text = "Сколько материала в пачке(м2):";
            // 
            // Calculating
            // 
            this.AcceptButton = this.okbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cnlbtn;
            this.ClientSize = new System.Drawing.Size(286, 368);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Calculating";
            this.Text = "Calculating";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cnlbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
    }
}