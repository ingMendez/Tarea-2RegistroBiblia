namespace RegistroBiblia.UI.Registros
{
    partial class rLibros
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LibroId_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Descripcion_textBox = new System.Windows.Forms.TextBox();
            this.Siglas_textBox = new System.Windows.Forms.TextBox();
            this.TipId_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Nuevo_button = new System.Windows.Forms.Button();
            this.Eliminar_button = new System.Windows.Forms.Button();
            this.Guardar_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibroId_numericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(-1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 53);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 39);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(81, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Registro De Libro De La Biblia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Libro Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Siglas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo Id";
            // 
            // LibroId_numericUpDown
            // 
            this.LibroId_numericUpDown.Location = new System.Drawing.Point(153, 68);
            this.LibroId_numericUpDown.Name = "LibroId_numericUpDown";
            this.LibroId_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.LibroId_numericUpDown.TabIndex = 10;
            // 
            // Descripcion_textBox
            // 
            this.Descripcion_textBox.Location = new System.Drawing.Point(153, 112);
            this.Descripcion_textBox.Name = "Descripcion_textBox";
            this.Descripcion_textBox.Size = new System.Drawing.Size(246, 20);
            this.Descripcion_textBox.TabIndex = 11;
            // 
            // Siglas_textBox
            // 
            this.Siglas_textBox.Location = new System.Drawing.Point(153, 154);
            this.Siglas_textBox.Name = "Siglas_textBox";
            this.Siglas_textBox.Size = new System.Drawing.Size(120, 20);
            this.Siglas_textBox.TabIndex = 12;
            // 
            // TipId_comboBox
            // 
            this.TipId_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipId_comboBox.FormattingEnabled = true;
            this.TipId_comboBox.Items.AddRange(new object[] {
            "",
            "Nuevo Testamento",
            "Antiguo Testamento"});
            this.TipId_comboBox.Location = new System.Drawing.Point(153, 197);
            this.TipId_comboBox.Name = "TipId_comboBox";
            this.TipId_comboBox.Size = new System.Drawing.Size(120, 21);
            this.TipId_comboBox.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Controls.Add(this.Nuevo_button);
            this.groupBox2.Controls.Add(this.Eliminar_button);
            this.groupBox2.Controls.Add(this.Guardar_button);
            this.groupBox2.Location = new System.Drawing.Point(153, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 48);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.Location = new System.Drawing.Point(6, 8);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(44, 40);
            this.Nuevo_button.TabIndex = 1;
            this.Nuevo_button.UseVisualStyleBackColor = true;
            // 
            // Eliminar_button
            // 
            this.Eliminar_button.Location = new System.Drawing.Point(167, 7);
            this.Eliminar_button.Name = "Eliminar_button";
            this.Eliminar_button.Size = new System.Drawing.Size(44, 40);
            this.Eliminar_button.TabIndex = 2;
            this.Eliminar_button.UseVisualStyleBackColor = true;
            // 
            // Guardar_button
            // 
            this.Guardar_button.Location = new System.Drawing.Point(88, 8);
            this.Guardar_button.Name = "Guardar_button";
            this.Guardar_button.Size = new System.Drawing.Size(44, 40);
            this.Guardar_button.TabIndex = 0;
            this.Guardar_button.UseVisualStyleBackColor = true;
            // 
            // rLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 299);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TipId_comboBox);
            this.Controls.Add(this.Siglas_textBox);
            this.Controls.Add(this.Descripcion_textBox);
            this.Controls.Add(this.LibroId_numericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "rLibros";
            this.Text = "rLibros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibroId_numericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown LibroId_numericUpDown;
        private System.Windows.Forms.TextBox Descripcion_textBox;
        private System.Windows.Forms.TextBox Siglas_textBox;
        private System.Windows.Forms.ComboBox TipId_comboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.Button Eliminar_button;
        private System.Windows.Forms.Button Guardar_button;
    }
}