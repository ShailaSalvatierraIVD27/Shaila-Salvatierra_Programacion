namespace Problema3_Shaila
{
    partial class Form1
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 0;
            label1.Text = "Sueldos Planilla";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(24, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 130);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Empleado";
            // 
            // button2
            // 
            button2.Location = new Point(281, 94);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Nuevo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(281, 59);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "A", "B" });
            comboBox1.Location = new Point(82, 92);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(69, 23);
            comboBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(93, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 23);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 59);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 2;
            label4.Text = "Años Laborados:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 94);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 1;
            label3.Text = "Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 25);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Empleado:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Enabled = false;
            groupBox2.Location = new Point(24, 217);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(367, 127);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sueldo Total";
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(293, 56);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(63, 23);
            textBox6.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Enabled = false;
            label8.Location = new Point(228, 61);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 12;
            label8.Text = "Categoria:";
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(95, 87);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(123, 23);
            textBox5.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Enabled = false;
            label7.Location = new Point(15, 90);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 8;
            label7.Text = "Sueldo Total:";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(125, 53);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(63, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(94, 19);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(262, 23);
            textBox4.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Location = new Point(15, 22);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 8;
            label6.Text = "Empleado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Location = new Point(15, 56);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 9;
            label5.Text = "Años Laborados:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 362);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private Label label5;
    }
}
