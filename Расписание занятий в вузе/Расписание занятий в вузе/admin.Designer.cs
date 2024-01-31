namespace Расписание_занятий_в_вузе
{
    partial class admin
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
            this.Gruppa = new System.Windows.Forms.Button();
            this.Prepodavatel = new System.Windows.Forms.Button();
            this.Disciplina = new System.Windows.Forms.Button();
            this.Auditoria = new System.Windows.Forms.Button();
            this.Raspisanie = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Gruppa
            // 
            this.Gruppa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Gruppa.Location = new System.Drawing.Point(89, 283);
            this.Gruppa.Name = "Gruppa";
            this.Gruppa.Size = new System.Drawing.Size(161, 42);
            this.Gruppa.TabIndex = 0;
            this.Gruppa.Text = "Группа ";
            this.Gruppa.UseVisualStyleBackColor = true;
            this.Gruppa.Click += new System.EventHandler(this.Gruppa_Click);
            // 
            // Prepodavatel
            // 
            this.Prepodavatel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Prepodavatel.Location = new System.Drawing.Point(89, 53);
            this.Prepodavatel.Name = "Prepodavatel";
            this.Prepodavatel.Size = new System.Drawing.Size(161, 42);
            this.Prepodavatel.TabIndex = 1;
            this.Prepodavatel.Text = "Преподаватель";
            this.Prepodavatel.UseVisualStyleBackColor = true;
            this.Prepodavatel.Click += new System.EventHandler(this.Prepodavatel_Click);
            // 
            // Disciplina
            // 
            this.Disciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Disciplina.Location = new System.Drawing.Point(89, 129);
            this.Disciplina.Name = "Disciplina";
            this.Disciplina.Size = new System.Drawing.Size(161, 42);
            this.Disciplina.TabIndex = 2;
            this.Disciplina.Text = "Дисциплина";
            this.Disciplina.UseVisualStyleBackColor = true;
            this.Disciplina.Click += new System.EventHandler(this.Disciplina_Click);
            // 
            // Auditoria
            // 
            this.Auditoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Auditoria.Location = new System.Drawing.Point(89, 207);
            this.Auditoria.Name = "Auditoria";
            this.Auditoria.Size = new System.Drawing.Size(161, 42);
            this.Auditoria.TabIndex = 3;
            this.Auditoria.Text = "Аудитория";
            this.Auditoria.UseVisualStyleBackColor = true;
            this.Auditoria.Click += new System.EventHandler(this.Auditoria_Click);
            // 
            // Raspisanie
            // 
            this.Raspisanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Raspisanie.Location = new System.Drawing.Point(89, 362);
            this.Raspisanie.Name = "Raspisanie";
            this.Raspisanie.Size = new System.Drawing.Size(161, 42);
            this.Raspisanie.TabIndex = 4;
            this.Raspisanie.Text = "Расписание";
            this.Raspisanie.UseVisualStyleBackColor = true;
            this.Raspisanie.Click += new System.EventHandler(this.Raspisanie_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.back.Location = new System.Drawing.Point(252, 442);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(79, 30);
            this.back.TabIndex = 47;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 484);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Raspisanie);
            this.Controls.Add(this.Auditoria);
            this.Controls.Add(this.Disciplina);
            this.Controls.Add(this.Prepodavatel);
            this.Controls.Add(this.Gruppa);
            this.Name = "admin";
            this.Text = "Админ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Gruppa;
        private System.Windows.Forms.Button Prepodavatel;
        private System.Windows.Forms.Button Disciplina;
        private System.Windows.Forms.Button Auditoria;
        private System.Windows.Forms.Button Raspisanie;
        private System.Windows.Forms.Button back;
    }
}