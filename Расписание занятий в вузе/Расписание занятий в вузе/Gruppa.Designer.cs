namespace Расписание_занятий_в_вузе
{
    partial class Gruppa
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
            this.kolvo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nazv = new System.Windows.Forms.TextBox();
            this.del = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(604, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Количество человек:";
            // 
            // kolvo
            // 
            this.kolvo.Location = new System.Drawing.Point(754, 58);
            this.kolvo.Name = "kolvo";
            this.kolvo.Size = new System.Drawing.Size(156, 20);
            this.kolvo.TabIndex = 14;
            this.kolvo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kolvo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(626, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Название группы:";
            // 
            // nazv
            // 
            this.nazv.Location = new System.Drawing.Point(754, 24);
            this.nazv.Name = "nazv";
            this.nazv.Size = new System.Drawing.Size(156, 20);
            this.nazv.TabIndex = 12;
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.del.Location = new System.Drawing.Point(301, 402);
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
            this.red.Location = new System.Drawing.Point(155, 402);
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
            this.add.Location = new System.Drawing.Point(12, 402);
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
            // Gruppa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kolvo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nazv);
            this.Controls.Add(this.del);
            this.Controls.Add(this.red);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Gruppa";
            this.Text = "Группа";
            this.Load += new System.EventHandler(this.Gruppa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kolvo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nazv;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button back;
    }
}