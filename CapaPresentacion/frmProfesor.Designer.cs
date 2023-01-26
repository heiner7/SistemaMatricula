namespace CapaPresentacion
{
    partial class frmProfesor
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
            this.btnConsultarProfesor = new System.Windows.Forms.Button();
            this.btnEliminarProfesor = new System.Windows.Forms.Button();
            this.btnModificarProfesor = new System.Windows.Forms.Button();
            this.dgvProfesor = new System.Windows.Forms.DataGridView();
            this.txtProfesor_direccion = new System.Windows.Forms.TextBox();
            this.txtProfesor_correoElectronico = new System.Windows.Forms.TextBox();
            this.txtProfesor_telefono = new System.Windows.Forms.TextBox();
            this.txtProfesor_segundoApellido = new System.Windows.Forms.TextBox();
            this.txtProfesor_primerApellido = new System.Windows.Forms.TextBox();
            this.txtProfesor_nombre = new System.Windows.Forms.TextBox();
            this.btnInsertarProfesor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProfesor_cedula = new System.Windows.Forms.TextBox();
            this.cbxConsulta = new System.Windows.Forms.ComboBox();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtFiltar_profesor = new System.Windows.Forms.TextBox();
            this.lbxBuscarProfesor = new System.Windows.Forms.ListBox();
            this.cmb_reports = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultarProfesor
            // 
            this.btnConsultarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarProfesor.Location = new System.Drawing.Point(440, 346);
            this.btnConsultarProfesor.Name = "btnConsultarProfesor";
            this.btnConsultarProfesor.Size = new System.Drawing.Size(101, 35);
            this.btnConsultarProfesor.TabIndex = 60;
            this.btnConsultarProfesor.Text = "Consultar";
            this.btnConsultarProfesor.UseVisualStyleBackColor = true;
            this.btnConsultarProfesor.Click += new System.EventHandler(this.btnConsultarProfesor_Click);
            // 
            // btnEliminarProfesor
            // 
            this.btnEliminarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProfesor.Location = new System.Drawing.Point(272, 346);
            this.btnEliminarProfesor.Name = "btnEliminarProfesor";
            this.btnEliminarProfesor.Size = new System.Drawing.Size(101, 35);
            this.btnEliminarProfesor.TabIndex = 59;
            this.btnEliminarProfesor.Text = "Inactivar";
            this.btnEliminarProfesor.UseVisualStyleBackColor = true;
            this.btnEliminarProfesor.Click += new System.EventHandler(this.btnEliminarProfesor_Click);
            // 
            // btnModificarProfesor
            // 
            this.btnModificarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProfesor.Location = new System.Drawing.Point(155, 346);
            this.btnModificarProfesor.Name = "btnModificarProfesor";
            this.btnModificarProfesor.Size = new System.Drawing.Size(101, 35);
            this.btnModificarProfesor.TabIndex = 58;
            this.btnModificarProfesor.Text = "Modificar";
            this.btnModificarProfesor.UseVisualStyleBackColor = true;
            this.btnModificarProfesor.Click += new System.EventHandler(this.btnModificarProfesor_Click);
            // 
            // dgvProfesor
            // 
            this.dgvProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesor.Location = new System.Drawing.Point(322, 24);
            this.dgvProfesor.Name = "dgvProfesor";
            this.dgvProfesor.Size = new System.Drawing.Size(424, 285);
            this.dgvProfesor.TabIndex = 56;
            this.dgvProfesor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesor_CellClick);
            // 
            // txtProfesor_direccion
            // 
            this.txtProfesor_direccion.Location = new System.Drawing.Point(135, 261);
            this.txtProfesor_direccion.Name = "txtProfesor_direccion";
            this.txtProfesor_direccion.Size = new System.Drawing.Size(139, 20);
            this.txtProfesor_direccion.TabIndex = 55;
            // 
            // txtProfesor_correoElectronico
            // 
            this.txtProfesor_correoElectronico.Location = new System.Drawing.Point(135, 216);
            this.txtProfesor_correoElectronico.Name = "txtProfesor_correoElectronico";
            this.txtProfesor_correoElectronico.Size = new System.Drawing.Size(139, 20);
            this.txtProfesor_correoElectronico.TabIndex = 54;
            // 
            // txtProfesor_telefono
            // 
            this.txtProfesor_telefono.Location = new System.Drawing.Point(135, 180);
            this.txtProfesor_telefono.Name = "txtProfesor_telefono";
            this.txtProfesor_telefono.Size = new System.Drawing.Size(139, 20);
            this.txtProfesor_telefono.TabIndex = 53;
            // 
            // txtProfesor_segundoApellido
            // 
            this.txtProfesor_segundoApellido.Location = new System.Drawing.Point(168, 137);
            this.txtProfesor_segundoApellido.Name = "txtProfesor_segundoApellido";
            this.txtProfesor_segundoApellido.Size = new System.Drawing.Size(139, 20);
            this.txtProfesor_segundoApellido.TabIndex = 52;
            // 
            // txtProfesor_primerApellido
            // 
            this.txtProfesor_primerApellido.Location = new System.Drawing.Point(153, 98);
            this.txtProfesor_primerApellido.Name = "txtProfesor_primerApellido";
            this.txtProfesor_primerApellido.Size = new System.Drawing.Size(139, 20);
            this.txtProfesor_primerApellido.TabIndex = 51;
            // 
            // txtProfesor_nombre
            // 
            this.txtProfesor_nombre.Location = new System.Drawing.Point(135, 60);
            this.txtProfesor_nombre.Name = "txtProfesor_nombre";
            this.txtProfesor_nombre.Size = new System.Drawing.Size(139, 20);
            this.txtProfesor_nombre.TabIndex = 50;
            // 
            // btnInsertarProfesor
            // 
            this.btnInsertarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarProfesor.Location = new System.Drawing.Point(39, 346);
            this.btnInsertarProfesor.Name = "btnInsertarProfesor";
            this.btnInsertarProfesor.Size = new System.Drawing.Size(101, 35);
            this.btnInsertarProfesor.TabIndex = 49;
            this.btnInsertarProfesor.Text = "Insertar";
            this.btnInsertarProfesor.UseVisualStyleBackColor = true;
            this.btnInsertarProfesor.Click += new System.EventHandler(this.btnInsertarProfesor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 18);
            this.label8.TabIndex = 48;
            this.label8.Text = "Dirección:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 47;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 46;
            this.label6.Text = "Télefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 18);
            this.label5.TabIndex = 45;
            this.label5.Text = "Segundo Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 44;
            this.label4.Text = "Primer Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Cédula:";
            // 
            // txtProfesor_cedula
            // 
            this.txtProfesor_cedula.Location = new System.Drawing.Point(135, 24);
            this.txtProfesor_cedula.Name = "txtProfesor_cedula";
            this.txtProfesor_cedula.Size = new System.Drawing.Size(139, 20);
            this.txtProfesor_cedula.TabIndex = 40;
            // 
            // cbxConsulta
            // 
            this.cbxConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConsulta.FormattingEnabled = true;
            this.cbxConsulta.Location = new System.Drawing.Point(547, 346);
            this.cbxConsulta.Name = "cbxConsulta";
            this.cbxConsulta.Size = new System.Drawing.Size(139, 21);
            this.cbxConsulta.TabIndex = 61;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // txtFiltar_profesor
            // 
            this.txtFiltar_profesor.Location = new System.Drawing.Point(752, 180);
            this.txtFiltar_profesor.Name = "txtFiltar_profesor";
            this.txtFiltar_profesor.Size = new System.Drawing.Size(139, 20);
            this.txtFiltar_profesor.TabIndex = 62;
            this.txtFiltar_profesor.TextChanged += new System.EventHandler(this.txtFiltar_profesor_TextChanged);
            // 
            // lbxBuscarProfesor
            // 
            this.lbxBuscarProfesor.FormattingEnabled = true;
            this.lbxBuscarProfesor.Location = new System.Drawing.Point(752, 24);
            this.lbxBuscarProfesor.Name = "lbxBuscarProfesor";
            this.lbxBuscarProfesor.Size = new System.Drawing.Size(180, 134);
            this.lbxBuscarProfesor.TabIndex = 63;
            this.lbxBuscarProfesor.SelectedIndexChanged += new System.EventHandler(this.lbxBuscarProfesor_SelectedIndexChanged);
            // 
            // cmb_reports
            // 
            this.cmb_reports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_reports.FormattingEnabled = true;
            this.cmb_reports.Items.AddRange(new object[] {
            "Todos",
            "Individual"});
            this.cmb_reports.Location = new System.Drawing.Point(760, 239);
            this.cmb_reports.Name = "cmb_reports";
            this.cmb_reports.Size = new System.Drawing.Size(139, 21);
            this.cmb_reports.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(757, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 18);
            this.label9.TabIndex = 70;
            this.label9.Text = "Elegir tipo Reporte:";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Enabled = false;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.Location = new System.Drawing.Point(760, 266);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(73, 27);
            this.btnGenerarReporte.TabIndex = 69;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // frmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(944, 413);
            this.Controls.Add(this.cmb_reports);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.lbxBuscarProfesor);
            this.Controls.Add(this.txtFiltar_profesor);
            this.Controls.Add(this.cbxConsulta);
            this.Controls.Add(this.btnConsultarProfesor);
            this.Controls.Add(this.btnEliminarProfesor);
            this.Controls.Add(this.btnModificarProfesor);
            this.Controls.Add(this.dgvProfesor);
            this.Controls.Add(this.txtProfesor_direccion);
            this.Controls.Add(this.txtProfesor_correoElectronico);
            this.Controls.Add(this.txtProfesor_telefono);
            this.Controls.Add(this.txtProfesor_segundoApellido);
            this.Controls.Add(this.txtProfesor_primerApellido);
            this.Controls.Add(this.txtProfesor_nombre);
            this.Controls.Add(this.btnInsertarProfesor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProfesor_cedula);
            this.Name = "frmProfesor";
            this.Text = "frmProfesor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProfesor_FormClosing);
            this.Load += new System.EventHandler(this.frmProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConsultarProfesor;
        private System.Windows.Forms.Button btnEliminarProfesor;
        private System.Windows.Forms.Button btnModificarProfesor;
        private System.Windows.Forms.DataGridView dgvProfesor;
        private System.Windows.Forms.TextBox txtProfesor_direccion;
        private System.Windows.Forms.TextBox txtProfesor_correoElectronico;
        private System.Windows.Forms.TextBox txtProfesor_telefono;
        private System.Windows.Forms.TextBox txtProfesor_segundoApellido;
        private System.Windows.Forms.TextBox txtProfesor_primerApellido;
        private System.Windows.Forms.TextBox txtProfesor_nombre;
        private System.Windows.Forms.Button btnInsertarProfesor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProfesor_cedula;
        private System.Windows.Forms.ComboBox cbxConsulta;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.TextBox txtFiltar_profesor;
        private System.Windows.Forms.ListBox lbxBuscarProfesor;
        private System.Windows.Forms.ComboBox cmb_reports;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGenerarReporte;
    }
}