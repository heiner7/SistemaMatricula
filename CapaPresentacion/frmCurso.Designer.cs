namespace CapaPresentacion
{
    partial class frmCurso
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
            this.btnInactivarCurso = new System.Windows.Forms.Button();
            this.btnModificarCurso = new System.Windows.Forms.Button();
            this.btnInsertarCupo = new System.Windows.Forms.Button();
            this.dgvCurso = new System.Windows.Forms.DataGridView();
            this.txtCurso_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurso_creditos = new System.Windows.Forms.TextBox();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbxBuscarCurso = new System.Windows.Forms.ListBox();
            this.txtFiltar_curso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurso_cupo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInactivarCurso
            // 
            this.btnInactivarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInactivarCurso.Location = new System.Drawing.Point(221, 224);
            this.btnInactivarCurso.Name = "btnInactivarCurso";
            this.btnInactivarCurso.Size = new System.Drawing.Size(86, 30);
            this.btnInactivarCurso.TabIndex = 11;
            this.btnInactivarCurso.Text = "Inactivar";
            this.btnInactivarCurso.UseVisualStyleBackColor = true;
            this.btnInactivarCurso.Click += new System.EventHandler(this.btnInactivarCurso_Click);
            // 
            // btnModificarCurso
            // 
            this.btnModificarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCurso.Location = new System.Drawing.Point(129, 224);
            this.btnModificarCurso.Name = "btnModificarCurso";
            this.btnModificarCurso.Size = new System.Drawing.Size(86, 30);
            this.btnModificarCurso.TabIndex = 10;
            this.btnModificarCurso.Text = "Modificar";
            this.btnModificarCurso.UseVisualStyleBackColor = true;
            this.btnModificarCurso.Click += new System.EventHandler(this.btnModificarCurso_Click);
            // 
            // btnInsertarCupo
            // 
            this.btnInsertarCupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarCupo.Location = new System.Drawing.Point(37, 224);
            this.btnInsertarCupo.Name = "btnInsertarCupo";
            this.btnInsertarCupo.Size = new System.Drawing.Size(86, 30);
            this.btnInsertarCupo.TabIndex = 9;
            this.btnInsertarCupo.Text = "Insertar";
            this.btnInsertarCupo.UseVisualStyleBackColor = true;
            this.btnInsertarCupo.Click += new System.EventHandler(this.btnInsertarCupo_Click);
            // 
            // dgvCurso
            // 
            this.dgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurso.Location = new System.Drawing.Point(340, 35);
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.Size = new System.Drawing.Size(281, 150);
            this.dgvCurso.TabIndex = 8;
            this.dgvCurso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurso_CellClick);
            // 
            // txtCurso_nombre
            // 
            this.txtCurso_nombre.Location = new System.Drawing.Point(116, 59);
            this.txtCurso_nombre.Name = "txtCurso_nombre";
            this.txtCurso_nombre.Size = new System.Drawing.Size(143, 20);
            this.txtCurso_nombre.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Creditos:";
            // 
            // txtCurso_creditos
            // 
            this.txtCurso_creditos.Location = new System.Drawing.Point(116, 114);
            this.txtCurso_creditos.Name = "txtCurso_creditos";
            this.txtCurso_creditos.Size = new System.Drawing.Size(143, 20);
            this.txtCurso_creditos.TabIndex = 13;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // lbxBuscarCurso
            // 
            this.lbxBuscarCurso.FormattingEnabled = true;
            this.lbxBuscarCurso.Location = new System.Drawing.Point(627, 35);
            this.lbxBuscarCurso.Name = "lbxBuscarCurso";
            this.lbxBuscarCurso.Size = new System.Drawing.Size(180, 134);
            this.lbxBuscarCurso.TabIndex = 65;
            this.lbxBuscarCurso.SelectedIndexChanged += new System.EventHandler(this.lbxBuscarCurso_SelectedIndexChanged);
            // 
            // txtFiltar_curso
            // 
            this.txtFiltar_curso.Location = new System.Drawing.Point(627, 191);
            this.txtFiltar_curso.Name = "txtFiltar_curso";
            this.txtFiltar_curso.Size = new System.Drawing.Size(139, 20);
            this.txtFiltar_curso.TabIndex = 64;
            this.txtFiltar_curso.TextChanged += new System.EventHandler(this.txtFiltar_curso_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cupo:";
            // 
            // txtCurso_cupo
            // 
            this.txtCurso_cupo.Location = new System.Drawing.Point(116, 165);
            this.txtCurso_cupo.Name = "txtCurso_cupo";
            this.txtCurso_cupo.Size = new System.Drawing.Size(143, 20);
            this.txtCurso_cupo.TabIndex = 15;
            // 
            // frmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(842, 279);
            this.Controls.Add(this.lbxBuscarCurso);
            this.Controls.Add(this.txtFiltar_curso);
            this.Controls.Add(this.txtCurso_cupo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCurso_creditos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInactivarCurso);
            this.Controls.Add(this.btnModificarCurso);
            this.Controls.Add(this.btnInsertarCupo);
            this.Controls.Add(this.dgvCurso);
            this.Controls.Add(this.txtCurso_nombre);
            this.Controls.Add(this.label1);
            this.Name = "frmCurso";
            this.Text = "frmCurso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCurso_FormClosing);
            this.Load += new System.EventHandler(this.frmCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInactivarCurso;
        private System.Windows.Forms.Button btnModificarCurso;
        private System.Windows.Forms.Button btnInsertarCupo;
        private System.Windows.Forms.DataGridView dgvCurso;
        private System.Windows.Forms.TextBox txtCurso_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurso_creditos;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ListBox lbxBuscarCurso;
        private System.Windows.Forms.TextBox txtFiltar_curso;
        private System.Windows.Forms.TextBox txtCurso_cupo;
        private System.Windows.Forms.Label label3;
    }
}