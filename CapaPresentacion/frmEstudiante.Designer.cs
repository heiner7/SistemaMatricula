namespace CapaPresentacion
{
    partial class frmEstudiante
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
            this.components = new System.ComponentModel.Container();
            this.txtEstudiante_direccion = new System.Windows.Forms.TextBox();
            this.txtEstudiante_correoElectronico = new System.Windows.Forms.TextBox();
            this.txtEstudiante_telefono = new System.Windows.Forms.TextBox();
            this.txtEstudiante_segundoApellido = new System.Windows.Forms.TextBox();
            this.txtEstudiante_primerApellido = new System.Windows.Forms.TextBox();
            this.txtEstudiante_nombre = new System.Windows.Forms.TextBox();
            this.btnInsertarEstudiante = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstudiante_cedula = new System.Windows.Forms.TextBox();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.cbxGrupo = new System.Windows.Forms.ComboBox();
            this.btnModificarEstudiante = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnInactivar = new System.Windows.Forms.Button();
            this.cbxConsulta = new System.Windows.Forms.ComboBox();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbxBuscarEstudiante = new System.Windows.Forms.ListBox();
            this.txtFiltar_estudiante = new System.Windows.Forms.TextBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_reports = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEstudiante_direccion
            // 
            this.txtEstudiante_direccion.Location = new System.Drawing.Point(136, 284);
            this.txtEstudiante_direccion.Name = "txtEstudiante_direccion";
            this.txtEstudiante_direccion.Size = new System.Drawing.Size(139, 20);
            this.txtEstudiante_direccion.TabIndex = 33;
            // 
            // txtEstudiante_correoElectronico
            // 
            this.txtEstudiante_correoElectronico.Location = new System.Drawing.Point(136, 242);
            this.txtEstudiante_correoElectronico.Name = "txtEstudiante_correoElectronico";
            this.txtEstudiante_correoElectronico.Size = new System.Drawing.Size(139, 20);
            this.txtEstudiante_correoElectronico.TabIndex = 32;
            // 
            // txtEstudiante_telefono
            // 
            this.txtEstudiante_telefono.Location = new System.Drawing.Point(136, 206);
            this.txtEstudiante_telefono.Name = "txtEstudiante_telefono";
            this.txtEstudiante_telefono.Size = new System.Drawing.Size(139, 20);
            this.txtEstudiante_telefono.TabIndex = 31;
            // 
            // txtEstudiante_segundoApellido
            // 
            this.txtEstudiante_segundoApellido.Location = new System.Drawing.Point(160, 160);
            this.txtEstudiante_segundoApellido.Name = "txtEstudiante_segundoApellido";
            this.txtEstudiante_segundoApellido.Size = new System.Drawing.Size(139, 20);
            this.txtEstudiante_segundoApellido.TabIndex = 30;
            // 
            // txtEstudiante_primerApellido
            // 
            this.txtEstudiante_primerApellido.Location = new System.Drawing.Point(148, 121);
            this.txtEstudiante_primerApellido.Name = "txtEstudiante_primerApellido";
            this.txtEstudiante_primerApellido.Size = new System.Drawing.Size(139, 20);
            this.txtEstudiante_primerApellido.TabIndex = 29;
            // 
            // txtEstudiante_nombre
            // 
            this.txtEstudiante_nombre.Location = new System.Drawing.Point(136, 86);
            this.txtEstudiante_nombre.Name = "txtEstudiante_nombre";
            this.txtEstudiante_nombre.Size = new System.Drawing.Size(139, 20);
            this.txtEstudiante_nombre.TabIndex = 28;
            // 
            // btnInsertarEstudiante
            // 
            this.btnInsertarEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarEstudiante.Location = new System.Drawing.Point(41, 341);
            this.btnInsertarEstudiante.Name = "btnInsertarEstudiante";
            this.btnInsertarEstudiante.Size = new System.Drawing.Size(101, 35);
            this.btnInsertarEstudiante.TabIndex = 27;
            this.btnInsertarEstudiante.Text = "Insertar";
            this.btnInsertarEstudiante.UseVisualStyleBackColor = true;
            this.btnInsertarEstudiante.Click += new System.EventHandler(this.btnInsertarEstudiante_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Télefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Segundo Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Primer Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cédula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Grupo:";
            // 
            // txtEstudiante_cedula
            // 
            this.txtEstudiante_cedula.Location = new System.Drawing.Point(136, 53);
            this.txtEstudiante_cedula.Name = "txtEstudiante_cedula";
            this.txtEstudiante_cedula.Size = new System.Drawing.Size(139, 20);
            this.txtEstudiante_cedula.TabIndex = 18;
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(324, 19);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.Size = new System.Drawing.Size(424, 285);
            this.dgvEstudiantes.TabIndex = 34;
            this.dgvEstudiantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiantes_CellClick);
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGrupo.FormattingEnabled = true;
            this.cbxGrupo.Location = new System.Drawing.Point(136, 11);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Size = new System.Drawing.Size(139, 21);
            this.cbxGrupo.TabIndex = 35;
            // 
            // btnModificarEstudiante
            // 
            this.btnModificarEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEstudiante.Location = new System.Drawing.Point(148, 341);
            this.btnModificarEstudiante.Name = "btnModificarEstudiante";
            this.btnModificarEstudiante.Size = new System.Drawing.Size(101, 35);
            this.btnModificarEstudiante.TabIndex = 36;
            this.btnModificarEstudiante.Text = "Modificar";
            this.btnModificarEstudiante.UseVisualStyleBackColor = true;
            this.btnModificarEstudiante.Click += new System.EventHandler(this.btnModificarEstudiante_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(488, 341);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(101, 35);
            this.btnConsultar.TabIndex = 38;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnInactivar
            // 
            this.btnInactivar.Enabled = false;
            this.btnInactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInactivar.Location = new System.Drawing.Point(381, 341);
            this.btnInactivar.Name = "btnInactivar";
            this.btnInactivar.Size = new System.Drawing.Size(101, 35);
            this.btnInactivar.TabIndex = 40;
            this.btnInactivar.Text = "Inactivar";
            this.btnInactivar.UseVisualStyleBackColor = true;
            this.btnInactivar.Click += new System.EventHandler(this.btnInactivar_Click);
            // 
            // cbxConsulta
            // 
            this.cbxConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxConsulta.FormattingEnabled = true;
            this.cbxConsulta.Location = new System.Drawing.Point(595, 341);
            this.cbxConsulta.Name = "cbxConsulta";
            this.cbxConsulta.Size = new System.Drawing.Size(139, 24);
            this.cbxConsulta.TabIndex = 41;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // lbxBuscarEstudiante
            // 
            this.lbxBuscarEstudiante.FormattingEnabled = true;
            this.lbxBuscarEstudiante.Location = new System.Drawing.Point(754, 19);
            this.lbxBuscarEstudiante.Name = "lbxBuscarEstudiante";
            this.lbxBuscarEstudiante.Size = new System.Drawing.Size(180, 134);
            this.lbxBuscarEstudiante.TabIndex = 64;
            this.lbxBuscarEstudiante.SelectedIndexChanged += new System.EventHandler(this.lbxBuscarEstudiante_SelectedIndexChanged);
            // 
            // txtFiltar_estudiante
            // 
            this.txtFiltar_estudiante.Location = new System.Drawing.Point(754, 163);
            this.txtFiltar_estudiante.Name = "txtFiltar_estudiante";
            this.txtFiltar_estudiante.Size = new System.Drawing.Size(139, 20);
            this.txtFiltar_estudiante.TabIndex = 65;
            this.txtFiltar_estudiante.TextChanged += new System.EventHandler(this.txtFiltar_estudiante_TextChanged);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Enabled = false;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.Location = new System.Drawing.Point(757, 256);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(73, 27);
            this.btnGenerarReporte.TabIndex = 66;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(754, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 18);
            this.label9.TabIndex = 67;
            this.label9.Text = "Elegir tipo Reporte:";
            // 
            // cmb_reports
            // 
            this.cmb_reports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_reports.FormattingEnabled = true;
            this.cmb_reports.Items.AddRange(new object[] {
            "Todos",
            "Individual"});
            this.cmb_reports.Location = new System.Drawing.Point(757, 229);
            this.cmb_reports.Name = "cmb_reports";
            this.cmb_reports.Size = new System.Drawing.Size(139, 21);
            this.cmb_reports.TabIndex = 68;
            // 
            // frmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(946, 393);
            this.Controls.Add(this.cmb_reports);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.txtFiltar_estudiante);
            this.Controls.Add(this.lbxBuscarEstudiante);
            this.Controls.Add(this.cbxConsulta);
            this.Controls.Add(this.btnInactivar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnModificarEstudiante);
            this.Controls.Add(this.cbxGrupo);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.txtEstudiante_direccion);
            this.Controls.Add(this.txtEstudiante_correoElectronico);
            this.Controls.Add(this.txtEstudiante_telefono);
            this.Controls.Add(this.txtEstudiante_segundoApellido);
            this.Controls.Add(this.txtEstudiante_primerApellido);
            this.Controls.Add(this.txtEstudiante_nombre);
            this.Controls.Add(this.btnInsertarEstudiante);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEstudiante_cedula);
            this.Name = "frmEstudiante";
            this.Text = "frmEstudiante";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEstudiante_FormClosing);
            this.Load += new System.EventHandler(this.frmEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstudiante_direccion;
        private System.Windows.Forms.TextBox txtEstudiante_correoElectronico;
        private System.Windows.Forms.TextBox txtEstudiante_telefono;
        private System.Windows.Forms.TextBox txtEstudiante_segundoApellido;
        private System.Windows.Forms.TextBox txtEstudiante_primerApellido;
        private System.Windows.Forms.TextBox txtEstudiante_nombre;
        private System.Windows.Forms.Button btnInsertarEstudiante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstudiante_cedula;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.ComboBox cbxGrupo;
        private System.Windows.Forms.Button btnModificarEstudiante;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnInactivar;
        private System.Windows.Forms.ComboBox cbxConsulta;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ListBox lbxBuscarEstudiante;
        private System.Windows.Forms.TextBox txtFiltar_estudiante;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.ComboBox cmb_reports;
        private System.Windows.Forms.Label label9;
    }
}