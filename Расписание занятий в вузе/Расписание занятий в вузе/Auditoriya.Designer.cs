namespace Расписание_занятий_в_вузе
{
    partial class Auditoriya
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.del = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nazv = new System.Windows.Forms.TextBox();
            this.etaj = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(708, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Этаж:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(603, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Название аудитории:";
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.del.Location = new System.Drawing.Point(302, 402);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(118, 36);
            this.del.TabIndex = 11;
            this.del.Text = "Удалить";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // red
            // 
            this.red.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.red.Location = new System.Drawing.Point(156, 402);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(118, 36);
            this.red.TabIndex = 10;
            this.red.Text = "Изменить";
            this.red.UseVisualStyleBackColor = true;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.add.Location = new System.Drawing.Point(13, 402);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(118, 36);
            this.add.TabIndex = 9;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(585, 352);
            this.dataGridView1.TabIndex = 8;
            // 
            // nazv
            // 
            this.nazv.Location = new System.Drawing.Point(755, 24);
            this.nazv.Name = "nazv";
            this.nazv.Size = new System.Drawing.Size(156, 20);
            this.nazv.TabIndex = 18;
            // 
            // etaj
            // 
            this.etaj.Location = new System.Drawing.Point(755, 58);
            this.etaj.Name = "etaj";
            this.etaj.Size = new System.Drawing.Size(156, 20);
            this.etaj.TabIndex = 19;
            this.etaj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.etaj_KeyPress);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.back.Location = new System.Drawing.Point(840, 402);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(118, 36);
            this.back.TabIndex = 46;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Auditoriya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.etaj);
            this.Controls.Add(this.nazv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.del);
            this.Controls.Add(this.red);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Auditoriya";
            this.Text = "Аудитория";
            this.Load += new System.EventHandler(this.Auditoriya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nazv;
        private System.Windows.Forms.TextBox etaj;
        private System.Windows.Forms.Button back;
    }
}