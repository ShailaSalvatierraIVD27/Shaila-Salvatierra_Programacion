namespace Problema2_Shaila
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
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 29);
            label1.Name = "label1";
            label1.Size = new Size(171, 50);
            label1.TabIndex = 0;
            label1.Text = "VENTAS";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 185);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 3;
            label3.Text = "Descuento 5% -";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Teclado Q.125.00", "Mouse Q.75.00", "Audifonos Q.150.00", "USB Q.60.00", "Memoria RAM Q.350.00" });
            comboBox1.Location = new Point(123, 143);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(156, 23);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Seleccione Producto";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(173, 183);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(39, 24);
            radioButton1.TabIndex = 6;
            radioButton1.Text = "Si";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(231, 185);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(48, 24);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "No";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 145);
            label4.Name = "label4";
            label4.Size = new Size(73, 18);
            label4.TabIndex = 9;
            label4.Text = "Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 105);
            label2.Name = "label2";
            label2.Size = new Size(94, 18);
            label2.TabIndex = 8;
            label2.Text = "No. Factura: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 270);
            label5.Name = "label5";
            label5.Size = new Size(74, 18);
            label5.TabIndex = 11;
            label5.Text = "Unidades:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(51, 233);
            label6.Name = "label6";
            label6.Size = new Size(75, 18);
            label6.TabIndex = 10;
            label6.Text = "Precio: Q.";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(123, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(89, 23);
            textBox2.TabIndex = 12;
            textBox2.Text = "0";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(123, 270);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(89, 23);
            textBox3.TabIndex = 13;
            textBox3.Text = "1";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(32, 312);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 14;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(150, 312);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 15;
            button2.Text = "Nuevo";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 388);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
    }
}
