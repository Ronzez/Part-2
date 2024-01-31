namespace Расписание_занятий_в_вузе
{
    partial class prepod
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.poisk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ub = new System.Windows.Forms.Button();
            this.vozr = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // poisk
            // 
            this.poisk.Location = new System.Drawing.Point(817, 37);
            this.poisk.Name = "poisk";
            this.poisk.Size = new System.Drawing.Size(100, 20);
            this.poisk.TabIndex = 1;
            this.poisk.TextChanged += new System.EventHandler(this.poisk_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(772, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск:";
            // 
            // ub
            // 
            this.ub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ub.Location = new System.Drawing.Point(788, 124);
            this.ub.Name = "ub";
            this.ub.Size = new System.Drawing.Size(169, 30);
            this.ub.TabIndex = 3;
            this.ub.Text = "Поиск по убыванию";
            this.ub.UseVisualStyleBackColor = true;
            this.ub.Click += new System.EventHandler(this.ub_Click);
            // 
            // vozr
            // 
            this.vozr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.vozr.Location = new System.Drawing.Point(788, 88);
            this.vozr.Name = "vozr";
            this.vozr.Size = new System.Drawing.Size(169, 30);
            this.vozr.TabIndex = 4;
            this.vozr.Text = "Поиск по возрастанию";
            this.vozr.UseVisualStyleBackColor = true;
            this.vozr.Click += new System.EventHandler(this.vozr_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.back.Location = new System.Drawing.Point(839, 402);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(118, 36);
            this.back.TabIndex = 47;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // prepod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.vozr);
            this.Controls.Add(this.ub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.poisk);
            this.Controls.Add(this.dataGridView1);
            this.Name = "prepod";
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.prepod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox poisk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ub;
        private System.Windows.Forms.Button vozr;
        private System.Windows.Forms.Button back;
    }
}