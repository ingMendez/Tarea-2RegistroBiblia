namespace RegistroBiblia.UI.Consultas
{
    partial class Cconsultas
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
            this.label1 = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.Nombre_textBox = new System.Windows.Forms.TextBox();
            this.Buscar_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TipId_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Location = new System.Drawing.Point(176, 33);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(58, 16);
            this.NombreLabel.TabIndex = 7;
            this.NombreLabel.Text = "Criterio";
            this.NombreLabel.Click += new System.EventHandler(this.NombreLabel_Click);
            // 
            // Nombre_textBox
            // 
            this.Nombre_textBox.Location = new System.Drawing.Point(179, 52);
            this.Nombre_textBox.Name = "Nombre_textBox";
            this.Nombre_textBox.Size = new System.Drawing.Size(246, 20);
            this.Nombre_textBox.TabIndex = 12;
            // 
            // Buscar_button
            // 
            this.Buscar_button.Location = new System.Drawing.Point(447, 36);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(75, 23);
            this.Buscar_button.TabIndex = 13;
            this.Buscar_button.Text = "Buscar";
            this.Buscar_button.UseVisualStyleBackColor = true;
            this.Buscar_button.Click += new System.EventHandler(this.Buscar_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 175);
            this.dataGridView1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Filtar";
            // 
            // TipId_comboBox
            // 
            this.TipId_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipId_comboBox.FormattingEnabled = true;
            this.TipId_comboBox.Items.AddRange(new object[] {
            "Tipo Id",
            "ID",
            "Referencia",
            ""});
            this.TipId_comboBox.Location = new System.Drawing.Point(34, 51);
            this.TipId_comboBox.Name = "TipId_comboBox";
            this.TipId_comboBox.Size = new System.Drawing.Size(120, 21);
            this.TipId_comboBox.TabIndex = 16;
            // 
            // Cconsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 264);
            this.Controls.Add(this.TipId_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Buscar_button);
            this.Controls.Add(this.Nombre_textBox);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.label1);
            this.Name = "Cconsultas";
            this.Text = "Cconsultas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.TextBox Nombre_textBox;
        private System.Windows.Forms.Button Buscar_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipId_comboBox;
    }
}