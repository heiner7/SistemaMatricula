namespace CapaPresentacion
{
    partial class frmMatricula
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxEstudiante = new System.Windows.Forms.ComboBox();
            this.cbxGrupo = new System.Windows.Forms.ComboBox();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.cbxProfesor = new System.Windows.Forms.ComboBox();
            this.cbxHorario = new System.Windows.Forms.ComboBox();
            this.cbxAula = new System.Windows.Forms.ComboBox();
            this.txtMatri_comprobante = new System.Windows.Forms.TextBox();
            this.dgvMatricula = new System.Windows.Forms.DataGridView();
            this.btnInsertarMatricula = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInactivar = new System.Windows.Forms.Button();
            this.txtFiltar_matricula = new System.Windows.Forms.TextBox();
            this.lbxBuscarMatricula = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatricula)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estudiante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grupo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Curso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Profesor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Horario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Aula:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Matricula_comprobante:";
            // 
            // cbxEstudiante
            // 
            this.cbxEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstudiante.FormattingEnabled = true;
            this.cbxEstudiante.Location = new System.Drawing.Point(97, 44);
            this.cbxEstudiante.Name = "cbxEstudiante";
            this.cbxEstudiante.Size = new System.Drawing.Size(139, 21);
            this.cbxEstudiante.TabIndex = 36;
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGrupo.FormattingEnabled = true;
            this.cbxGrupo.Location = new System.Drawing.Point(97, 93);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Size = new System.Drawing.Size(139, 21);
            this.cbxGrupo.TabIndex = 37;
            // 
            // cbxCurso
            // 
            this.cbxCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Location = new System.Drawing.Point(97, 144);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(139, 21);
            this.cbxCurso.TabIndex = 38;
            // 
            // cbxProfesor
            // 
            this.cbxProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProfesor.FormattingEnabled = true;
            this.cbxProfesor.Location = new System.Drawing.Point(97, 198);
            this.cbxProfesor.Name = "cbxProfesor";
            this.cbxProfesor.Size = new System.Drawing.Size(139, 21);
            this.cbxProfesor.TabIndex = 39;
            // 
            // cbxHorario
            // 
            this.cbxHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHorario.FormattingEnabled = true;
            this.cbxHorario.Location = new System.Drawing.Point(97, 251);
            this.cbxHorario.Name = "cbxHorario";
            this.cbxHorario.Size = new System.Drawing.Size(139, 21);
            this.cbxHorario.TabIndex = 40;
            // 
            // cbxAula
            // 
            this.cbxAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAula.FormattingEnabled = true;
            this.cbxAula.Location = new System.Drawing.Point(97, 299);
            this.cbxAula.Name = "cbxAula";
            this.cbxAula.Size = new System.Drawing.Size(139, 21);
            this.cbxAula.TabIndex = 41;
            // 
            // txtMatri_comprobante
            // 
            this.txtMatri_comprobante.Location = new System.Drawing.Point(158, 354);
            this.txtMatri_comprobante.Name = "txtMatri_comprobante";
            this.txtMatri_comprobante.Size = new System.Drawing.Size(116, 20);
            this.txtMatri_comprobante.TabIndex = 42;
            // 
            // dgvMatricula
            // 
            this.dgvMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatricula.Location = new System.Drawing.Point(287, 44);
            this.dgvMatricula.Name = "dgvMatricula";
            this.dgvMatricula.Size = new System.Drawing.Size(424, 285);
            this.dgvMatricula.TabIndex = 44;
            this.dgvMatricula.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatricula_CellClick);
            // 
            // btnInsertarMatricula
            // 
            this.btnInsertarMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarMatricula.Location = new System.Drawing.Point(287, 339);
            this.btnInsertarMatricula.Name = "btnInsertarMatricula";
            this.btnInsertarMatricula.Size = new System.Drawing.Size(101, 35);
            this.btnInsertarMatricula.TabIndex = 45;
            this.btnInsertarMatricula.Text = "Insertar";
            this.btnInsertarMatricula.UseVisualStyleBackColor = true;
            this.btnInsertarMatricula.Click += new System.EventHandler(this.btnInsertarMatricula_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(394, 339);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 35);
            this.btnModificar.TabIndex = 46;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInactivar
            // 
            this.btnInactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInactivar.Location = new System.Drawing.Point(501, 339);
            this.btnInactivar.Name = "btnInactivar";
            this.btnInactivar.Size = new System.Drawing.Size(101, 35);
            this.btnInactivar.TabIndex = 47;
            this.btnInactivar.Text = "Inactivar";
            this.btnInactivar.UseVisualStyleBackColor = true;
            this.btnInactivar.Click += new System.EventHandler(this.btnInactivar_Click);
            // 
            // txtFiltar_matricula
            // 
            this.txtFiltar_matricula.Location = new System.Drawing.Point(717, 188);
            this.txtFiltar_matricula.Name = "txtFiltar_matricula";
            this.txtFiltar_matricula.Size = new System.Drawing.Size(139, 20);
            this.txtFiltar_matricula.TabIndex = 67;
            this.txtFiltar_matricula.TextChanged += new System.EventHandler(this.txtFiltar_matricula_TextChanged);
            // 
            // lbxBuscarMatricula
            // 
            this.lbxBuscarMatricula.FormattingEnabled = true;
            this.lbxBuscarMatricula.Location = new System.Drawing.Point(717, 44);
            this.lbxBuscarMatricula.Name = "lbxBuscarMatricula";
            this.lbxBuscarMatricula.Size = new System.Drawing.Size(180, 134);
            this.lbxBuscarMatricula.TabIndex = 66;
            this.lbxBuscarMatricula.SelectedIndexChanged += new System.EventHandler(this.lbxBuscarMatricula_SelectedIndexChanged);
            // 
            // frmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(905, 402);
            this.Controls.Add(this.txtFiltar_matricula);
            this.Controls.Add(this.lbxBuscarMatricula);
            this.Controls.Add(this.btnInactivar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertarMatricula);
            this.Controls.Add(this.dgvMatricula);
            this.Controls.Add(this.txtMatri_comprobante);
            this.Controls.Add(this.cbxAula);
            this.Controls.Add(this.cbxHorario);
            this.Controls.Add(this.cbxProfesor);
            this.Controls.Add(this.cbxCurso);
            this.Controls.Add(this.cbxGrupo);
            this.Controls.Add(this.cbxEstudiante);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMatricula";
            this.Text = "frmMatricula";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMatricula_FormClosing);
            this.Load += new System.EventHandler(this.frmMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatricula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxEstudiante;
        private System.Windows.Forms.ComboBox cbxGrupo;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.ComboBox cbxProfesor;
        private System.Windows.Forms.ComboBox cbxHorario;
        private System.Windows.Forms.ComboBox cbxAula;
        private System.Windows.Forms.TextBox txtMatri_comprobante;
        private System.Windows.Forms.DataGridView dgvMatricula;
        private System.Windows.Forms.Button btnInsertarMatricula;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInactivar;
        private System.Windows.Forms.TextBox txtFiltar_matricula;
        private System.Windows.Forms.ListBox lbxBuscarMatricula;
    }
}