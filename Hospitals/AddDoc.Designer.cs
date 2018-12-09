namespace Hospitals
{
    partial class AddDoc
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
            this.hospitalsDataSet1 = new Hospitals.HospitalsDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.HospitalBox = new System.Windows.Forms.TextBox();
            this.DoctorBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // hospitalsDataSet1
            // 
            this.hospitalsDataSet1.DataSetName = "HospitalsDataSet";
            this.hospitalsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HospitalBox
            // 
            this.HospitalBox.Location = new System.Drawing.Point(74, 27);
            this.HospitalBox.Name = "HospitalBox";
            this.HospitalBox.Size = new System.Drawing.Size(100, 20);
            this.HospitalBox.TabIndex = 2;
            // 
            // DoctorBox
            // 
            this.DoctorBox.Location = new System.Drawing.Point(74, 74);
            this.DoctorBox.Name = "DoctorBox";
            this.DoctorBox.Size = new System.Drawing.Size(100, 20);
            this.DoctorBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hospial ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Doctor ID";
            // 
            // AddDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoctorBox);
            this.Controls.Add(this.HospitalBox);
            this.Controls.Add(this.button1);
            this.Name = "AddDoc";
            this.Text = "AddDoc";
            ((System.ComponentModel.ISupportInitialize)(this.hospitalsDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HospitalsDataSet hospitalsDataSet1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox HospitalBox;
        private System.Windows.Forms.TextBox DoctorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}