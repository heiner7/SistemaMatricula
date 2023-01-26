namespace CapaPresentacion
{
    partial class frmEliminar
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
            this.dgvTablas = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.Tablas = new System.Windows.Forms.Label();
            this.cbxTabla = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablas
            // 
            this.dgvTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablas.Location = new System.Drawing.Point(41, 50);
            this.dgvTablas.Name = "dgvTablas";
            this.dgvTablas.Size = new System.Drawing.Size(424, 285);
            this.dgvTablas.TabIndex = 35;
            this.dgvTablas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablas_CellClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(494, 300);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 35);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Tablas
            // 
            this.Tablas.AutoSize = true;
            this.Tablas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tablas.ForeColor = System.Drawing.Color.Blue;
            this.Tablas.Location = new System.Drawing.Point(487, 55);
            this.Tablas.Name = "Tablas";
            this.Tablas.Size = new System.Drawing.Size(58, 18);
            this.Tablas.TabIndex = 39;
            this.Tablas.Text = "Tablas";
            // 
            // cbxTabla
            // 
            this.cbxTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTabla.FormattingEnabled = true;
            this.cbxTabla.Items.AddRange(new object[] {
            "Estudiante",
            "Profesor"});
            this.cbxTabla.Location = new System.Drawing.Point(569, 50);
            this.cbxTabla.Name = "cbxTabla";
            this.cbxTabla.Size = new System.Drawing.Size(139, 24);
            this.cbxTabla.TabIndex = 42;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Green;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConsultar.Location = new System.Drawing.Point(490, 111);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(101, 35);
            this.btnConsultar.TabIndex = 43;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(721, 357);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cbxTabla);
            this.Controls.Add(this.Tablas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvTablas);
            this.Name = "frmEliminar";
            this.Text = "frmEliminar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEliminar_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label Tablas;
        private System.Windows.Forms.ComboBox cbxTabla;
        private System.Windows.Forms.Button btnConsultar;
    }
}