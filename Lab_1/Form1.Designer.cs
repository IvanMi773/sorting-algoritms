
namespace Lab_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.addBTN = new System.Windows.Forms.Button();
            this.saveBTN = new System.Windows.Forms.Button();
            this.loadBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sortByNameBTN = new System.Windows.Forms.Button();
            this.sortByPopulationBTN = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Прізвище";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Рік народження";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 36);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTB_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(216, 36);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 22);
            this.textBox3.TabIndex = 3;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.populationTB_KeyPress);
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(601, 16);
            this.addBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(145, 42);
            this.addBTN.TabIndex = 4;
            this.addBTN.Text = "Додати";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(216, 84);
            this.saveBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(184, 39);
            this.saveBTN.TabIndex = 9;
            this.saveBTN.Text = "Записати";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // loadBTN
            // 
            this.loadBTN.Location = new System.Drawing.Point(405, 84);
            this.loadBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadBTN.Name = "loadBTN";
            this.loadBTN.Size = new System.Drawing.Size(212, 39);
            this.loadBTN.TabIndex = 10;
            this.loadBTN.Text = "Зчитати";
            this.loadBTN.UseVisualStyleBackColor = true;
            this.loadBTN.Click += new System.EventHandler(this.loadBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Список";
            // 
            // sortByNameBTN
            // 
            this.sortByNameBTN.Location = new System.Drawing.Point(149, 498);
            this.sortByNameBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortByNameBTN.Name = "sortByNameBTN";
            this.sortByNameBTN.Size = new System.Drawing.Size(251, 53);
            this.sortByNameBTN.TabIndex = 15;
            this.sortByNameBTN.Text = "Сортування по прізвищу";
            this.sortByNameBTN.UseVisualStyleBackColor = true;
            this.sortByNameBTN.Click += new System.EventHandler(this.sortByNameBTN_Click);
            // 
            // sortByPopulationBTN
            // 
            this.sortByPopulationBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortByPopulationBTN.Location = new System.Drawing.Point(405, 498);
            this.sortByPopulationBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortByPopulationBTN.Name = "sortByPopulationBTN";
            this.sortByPopulationBTN.Size = new System.Drawing.Size(237, 53);
            this.sortByPopulationBTN.TabIndex = 16;
            this.sortByPopulationBTN.Text = "Сортування по року народження";
            this.sortByPopulationBTN.UseVisualStyleBackColor = true;
            this.sortByPopulationBTN.Click += new System.EventHandler(this.sortByYearBTN_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(401, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Вид спорту";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 181);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(576, 263);
            this.dataGridView1.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(351, 460);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Сортування:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(260, 577);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 22);
            this.textBox4.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 574);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 23;
            this.button1.Text = "Знайти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 630);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sortByPopulationBTN);
            this.Controls.Add(this.sortByNameBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loadBTN);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting Algorithms";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Button loadBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sortByNameBTN;
        private System.Windows.Forms.Button sortByPopulationBTN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
    }
}

