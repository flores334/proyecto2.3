namespace proyectParcial
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbfechacita = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbduipaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbpaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbidmedico = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(415, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Programar Cita";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.txbidmedico);
            this.panel1.Controls.Add(this.txbfechacita);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbduipaciente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbpaciente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 592);
            this.panel1.TabIndex = 2;
            // 
            // txbfechacita
            // 
            this.txbfechacita.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txbfechacita.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbfechacita.ForeColor = System.Drawing.SystemColors.Window;
            this.txbfechacita.Location = new System.Drawing.Point(388, 390);
            this.txbfechacita.Name = "txbfechacita";
            this.txbfechacita.Size = new System.Drawing.Size(251, 30);
            this.txbfechacita.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(382, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de la Cita";
            // 
            // txbduipaciente
            // 
            this.txbduipaciente.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txbduipaciente.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbduipaciente.ForeColor = System.Drawing.SystemColors.Window;
            this.txbduipaciente.Location = new System.Drawing.Point(388, 294);
            this.txbduipaciente.Name = "txbduipaciente";
            this.txbduipaciente.Size = new System.Drawing.Size(251, 30);
            this.txbduipaciente.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(382, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "DUI  Del Paciente";
            // 
            // txbpaciente
            // 
            this.txbpaciente.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txbpaciente.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbpaciente.ForeColor = System.Drawing.SystemColors.Window;
            this.txbpaciente.Location = new System.Drawing.Point(388, 180);
            this.txbpaciente.Name = "txbpaciente";
            this.txbpaciente.Size = new System.Drawing.Size(251, 30);
            this.txbpaciente.TabIndex = 5;
            this.txbpaciente.Text = "\r\n";
            this.txbpaciente.TextChanged += new System.EventHandler(this.txbpaciente_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(382, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre del paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(382, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Medico";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyectParcial.Properties.Resources.Cita_medica;
            this.pictureBox1.Location = new System.Drawing.Point(16, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 462);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txbidmedico
            // 
            this.txbidmedico.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txbidmedico.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbidmedico.ForeColor = System.Drawing.SystemColors.Window;
            this.txbidmedico.Location = new System.Drawing.Point(388, 70);
            this.txbidmedico.Name = "txbidmedico";
            this.txbidmedico.Size = new System.Drawing.Size(251, 30);
            this.txbidmedico.TabIndex = 10;
            this.txbidmedico.Text = "\r\n";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbpaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbduipaciente;
        private System.Windows.Forms.TextBox txbfechacita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbidmedico;
    }
}