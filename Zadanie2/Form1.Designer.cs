namespace Zadanie2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.updatebtn = new System.Windows.Forms.Button();
            this.changebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.newbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.FIOBox = new System.Windows.Forms.TextBox();
            this.nomerBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(401, 522);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.idBox);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 546);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Turquoise;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.searchBox);
            this.panel4.Location = new System.Drawing.Point(412, 282);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(379, 252);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "Поиск:";
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBox.Location = new System.Drawing.Point(138, 110);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(237, 35);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Controls.Add(this.updatebtn);
            this.panel3.Controls.Add(this.changebtn);
            this.panel3.Controls.Add(this.deletebtn);
            this.panel3.Controls.Add(this.newbtn);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(797, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 521);
            this.panel3.TabIndex = 2;
            // 
            // updatebtn
            // 
            this.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updatebtn.Location = new System.Drawing.Point(48, 410);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(223, 53);
            this.updatebtn.TabIndex = 4;
            this.updatebtn.Text = "Сохранить";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // changebtn
            // 
            this.changebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changebtn.Location = new System.Drawing.Point(48, 304);
            this.changebtn.Name = "changebtn";
            this.changebtn.Size = new System.Drawing.Size(223, 53);
            this.changebtn.TabIndex = 3;
            this.changebtn.Text = "Изменить";
            this.changebtn.UseVisualStyleBackColor = true;
            this.changebtn.Click += new System.EventHandler(this.changebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deletebtn.Location = new System.Drawing.Point(48, 199);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(223, 53);
            this.deletebtn.TabIndex = 2;
            this.deletebtn.Text = "Удалить";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // newbtn
            // 
            this.newbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newbtn.Location = new System.Drawing.Point(48, 98);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(223, 53);
            this.newbtn.TabIndex = 1;
            this.newbtn.Text = "Новая запись";
            this.newbtn.UseVisualStyleBackColor = true;
            this.newbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Управление:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.FIOBox);
            this.panel2.Controls.Add(this.nomerBox);
            this.panel2.Location = new System.Drawing.Point(412, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 252);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(118, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Запись:";
            // 
            // FIOBox
            // 
            this.FIOBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOBox.Location = new System.Drawing.Point(3, 147);
            this.FIOBox.Name = "FIOBox";
            this.FIOBox.Size = new System.Drawing.Size(372, 35);
            this.FIOBox.TabIndex = 1;
            // 
            // nomerBox
            // 
            this.nomerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nomerBox.Location = new System.Drawing.Point(3, 98);
            this.nomerBox.Name = "nomerBox";
            this.nomerBox.Size = new System.Drawing.Size(372, 35);
            this.nomerBox.TabIndex = 0;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(601, 261);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(10, 26);
            this.idBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 546);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button changebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FIOBox;
        private System.Windows.Forms.TextBox nomerBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TextBox idBox;
    }
}

