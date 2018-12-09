namespace Hospitals
{
    partial class MainForm
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
            this.HospitalAddButton = new System.Windows.Forms.Button();
            this.DoctorAddButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HospitalAddButton
            // 
            this.HospitalAddButton.Location = new System.Drawing.Point(12, 12);
            this.HospitalAddButton.Name = "HospitalAddButton";
            this.HospitalAddButton.Size = new System.Drawing.Size(75, 23);
            this.HospitalAddButton.TabIndex = 0;
            this.HospitalAddButton.Text = "Add Hospital";
            this.HospitalAddButton.UseMnemonic = false;
            this.HospitalAddButton.UseVisualStyleBackColor = true;
            this.HospitalAddButton.Click += new System.EventHandler(this.HospitalAddButton_Click);
            // 
            // DoctorAddButton
            // 
            this.DoctorAddButton.Location = new System.Drawing.Point(120, 12);
            this.DoctorAddButton.Name = "DoctorAddButton";
            this.DoctorAddButton.Size = new System.Drawing.Size(75, 23);
            this.DoctorAddButton.TabIndex = 1;
            this.DoctorAddButton.Text = "Add Doctor";
            this.DoctorAddButton.UseVisualStyleBackColor = true;
            this.DoctorAddButton.Click += new System.EventHandler(this.DoctorAddButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(235, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add Doctor To Hospital";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DoctorAddButton);
            this.Controls.Add(this.HospitalAddButton);
            this.Name = "MainForm";
            this.Text = "Hospital Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HospitalAddButton;
        private System.Windows.Forms.Button DoctorAddButton;
        private System.Windows.Forms.Button button3;
    }
}

