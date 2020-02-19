namespace игровой_автомат
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.start1 = new System.Windows.Forms.Button();
            this.name1 = new System.Windows.Forms.Label();
            this.cash1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(239, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // start1
            // 
            this.start1.Location = new System.Drawing.Point(414, 82);
            this.start1.Name = "start1";
            this.start1.Size = new System.Drawing.Size(75, 23);
            this.start1.TabIndex = 2;
            this.start1.Text = "СТАРТ!";
            this.start1.UseVisualStyleBackColor = true;
            this.start1.Click += new System.EventHandler(this.start1_Click);
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Location = new System.Drawing.Point(123, 73);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(99, 13);
            this.name1.TabIndex = 3;
            this.name1.Text = "Введите свое имя";
            // 
            // cash1
            // 
            this.cash1.AutoSize = true;
            this.cash1.Location = new System.Drawing.Point(114, 104);
            this.cash1.Name = "cash1";
            this.cash1.Size = new System.Drawing.Size(119, 13);
            this.cash1.TabIndex = 4;
            this.cash1.Text = "Введите ваш кошелек";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cash1);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.start1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button start1;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.Label cash1;
    }
}

