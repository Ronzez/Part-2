namespace Расписание_занятий_в_вузе
{
    partial class Raspisanie
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.del = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Fam = new System.Windows.Forms.ComboBox();
            this.Audit = new System.Windows.Forms.ComboBox();
            this.Disc = new System.Windows.Forms.ComboBox();
            this.Gruppa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(801, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Аудитория:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(838, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "ФИО:";
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.del.Location = new System.Drawing.Point(301, 402);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(118, 36);
            this.del.TabIndex = 23;
            this.del.Text = "Удалить";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // red
            // 
            this.red.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.red.Location = new System.Drawing.Point(155, 402);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(118, 36);
            this.red.TabIndex = 22;
            this.red.Text = "Изменить";
            this.red.UseVisualStyleBackColor = true;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.add.Location = new System.Drawing.Point(12, 402);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(118, 36);
            this.add.TabIndex = 21;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 352);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(790, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Дисциплина:";
            // 
            // Fam
            // 
            this.Fam.FormattingEnabled = true;
            this.Fam.Location = new System.Drawing.Point(890, 22);
            this.Fam.Name = "Fam";
            this.Fam.Size = new System.Drawing.Size(148, 21);
            this.Fam.TabIndex = 34;
            // 
            // Audit
            // 
            this.Audit.FormattingEnabled = true;
            this.Audit.Location = new System.Drawing.Point(890, 58);
            this.Audit.Name = "Audit";
            this.Audit.Size = new System.Drawing.Size(148, 21);
            this.Audit.TabIndex = 37;
            // 
            // Disc
            // 
            this.Disc.FormattingEnabled = true;
            this.Disc.Location = new System.Drawing.Point(890, 93);
            this.Disc.Name = "Disc";
            this.Disc.Size = new System.Drawing.Size(148, 21);
            this.Disc.TabIndex = 38;
            // 
            // Gruppa
            // 
            this.Gruppa.FormattingEnabled = true;
            this.Gruppa.Location = new System.Drawing.Point(890, 128);
            this.Gruppa.Name = "Gruppa";
            this.Gruppa.Size = new System.Drawing.Size(148, 21);
            this.Gruppa.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(825, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Группа:";
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.save.Location = new System.Drawing.Point(828, 402);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(118, 36);
            this.save.TabIndex = 43;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.back.Location = new System.Drawing.Point(981, 402);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(118, 36);
            this.back.TabIndex = 44;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Raspisanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Gruppa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Disc);
            this.Controls.Add(this.Audit);
            this.Controls.Add(this.Fam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.del);
            this.Controls.Add(this.red);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Raspisanie";
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.Raspisanie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Fam;
        private System.Windows.Forms.ComboBox Audit;
        private System.Windows.Forms.ComboBox Disc;
        private System.Windows.Forms.ComboBox Gruppa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button back;
    }
}