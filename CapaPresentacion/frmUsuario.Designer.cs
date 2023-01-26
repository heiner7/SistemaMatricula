namespace CapaPresentacion
{
    partial class frmUsuario
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
            this.lbxBuscarUsuario = new System.Windows.Forms.ListBox();
            this.txtFiltar_usuario = new System.Windows.Forms.TextBox();
            this.txtUsuario_contrasenna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInactivarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnInsertarUsuario = new System.Windows.Forms.Button();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.txtUsuario_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxBuscarUsuario
            // 
            this.lbxBuscarUsuario.FormattingEnabled = true;
            this.lbxBuscarUsuario.Location = new System.Drawing.Point(567, 32);
            this.lbxBuscarUsuario.Name = "lbxBuscarUsuario";
            this.lbxBuscarUsuario.Size = new System.Drawing.Size(180, 134);
            this.lbxBuscarUsuario.TabIndex = 77;
            this.lbxBuscarUsuario.SelectedIndexChanged += new System.EventHandler(this.lbxBuscarUsuario_SelectedIndexChanged);
            // 
            // txtFiltar_usuario
            // 
            this.txtFiltar_usuario.Location = new System.Drawing.Point(567, 188);
            this.txtFiltar_usuario.Name = "txtFiltar_usuario";
            this.txtFiltar_usuario.Size = new System.Drawing.Size(139, 20);
            this.txtFiltar_usuario.TabIndex = 76;
            this.txtFiltar_usuario.TextChanged += new System.EventHandler(this.txtFiltar_usuario_TextChanged);
            // 
            // txtUsuario_contrasenna
            // 
            this.txtUsuario_contrasenna.Location = new System.Drawing.Point(111, 114);
            this.txtUsuario_contrasenna.Name = "txtUsuario_contrasenna";
            this.txtUsuario_contrasenna.Size = new System.Drawing.Size(143, 20);
            this.txtUsuario_contrasenna.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 72;
            this.label2.Text = "Contraseña:";
            // 
            // btnInactivarUsuario
            // 
            this.btnInactivarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInactivarUsuario.Location = new System.Drawing.Point(212, 152);
            this.btnInactivarUsuario.Name = "btnInactivarUsuario";
            this.btnInactivarUsuario.Size = new System.Drawing.Size(86, 30);
            this.btnInactivarUsuario.TabIndex = 71;
            this.btnInactivarUsuario.Text = "Inactivar";
            this.btnInactivarUsuario.UseVisualStyleBackColor = true;
            this.btnInactivarUsuario.Click += new System.EventHandler(this.btnInactivarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.Location = new System.Drawing.Point(120, 152);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(86, 30);
            this.btnModificarUsuario.TabIndex = 70;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnInsertarUsuario
            // 
            this.btnInsertarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarUsuario.Location = new System.Drawing.Point(28, 152);
            this.btnInsertarUsuario.Name = "btnInsertarUsuario";
            this.btnInsertarUsuario.Size = new System.Drawing.Size(86, 30);
            this.btnInsertarUsuario.TabIndex = 69;
            this.btnInsertarUsuario.Text = "Insertar";
            this.btnInsertarUsuario.UseVisualStyleBackColor = true;
            this.btnInsertarUsuario.Click += new System.EventHandler(this.btnInsertarUsuario_Click);
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(322, 32);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(239, 150);
            this.dgvUsuario.TabIndex = 68;
            this.dgvUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellClick);
            // 
            // txtUsuario_nombre
            // 
            this.txtUsuario_nombre.Location = new System.Drawing.Point(98, 56);
            this.txtUsuario_nombre.Name = "txtUsuario_nombre";
            this.txtUsuario_nombre.Size = new System.Drawing.Size(143, 20);
            this.txtUsuario_nombre.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 66;
            this.label1.Text = "Nombre:";
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(758, 232);
            this.Controls.Add(this.lbxBuscarUsuario);
            this.Controls.Add(this.txtFiltar_usuario);
            this.Controls.Add(this.txtUsuario_contrasenna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInactivarUsuario);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnInsertarUsuario);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.txtUsuario_nombre);
            this.Controls.Add(this.label1);
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUsuario_FormClosing);
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxBuscarUsuario;
        private System.Windows.Forms.TextBox txtFiltar_usuario;
        private System.Windows.Forms.TextBox txtUsuario_contrasenna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInactivarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnInsertarUsuario;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.TextBox txtUsuario_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider epError;
    }
}