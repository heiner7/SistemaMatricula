namespace CapaPresentacion
{
    partial class frmAula
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dgvAula = new System.Windows.Forms.DataGridView();
            this.txtAula_descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbxBuscarAula = new System.Windows.Forms.ListBox();
            this.txtFiltar_aula = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(251, 153);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 30);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Inactivar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(146, 153);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 30);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(43, 153);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(86, 30);
            this.btnInsertar.TabIndex = 9;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dgvAula
            // 
            this.dgvAula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAula.Location = new System.Drawing.Point(357, 33);
            this.dgvAula.Name = "dgvAula";
            this.dgvAula.Size = new System.Drawing.Size(244, 150);
            this.dgvAula.TabIndex = 8;
            this.dgvAula.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAula_CellClick);
            // 
            // txtAula_descripcion
            // 
            this.txtAula_descripcion.Location = new System.Drawing.Point(133, 57);
            this.txtAula_descripcion.Name = "txtAula_descripcion";
            this.txtAula_descripcion.Size = new System.Drawing.Size(143, 20);
            this.txtAula_descripcion.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descripción:";
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // lbxBuscarAula
            // 
            this.lbxBuscarAula.FormattingEnabled = true;
            this.lbxBuscarAula.Location = new System.Drawing.Point(617, 33);
            this.lbxBuscarAula.Name = "lbxBuscarAula";
            this.lbxBuscarAula.Size = new System.Drawing.Size(180, 134);
            this.lbxBuscarAula.TabIndex = 65;
            this.lbxBuscarAula.SelectedIndexChanged += new System.EventHandler(this.lbxBuscarAula_SelectedIndexChanged);
            // 
            // txtFiltar_aula
            // 
            this.txtFiltar_aula.Location = new System.Drawing.Point(617, 189);
            this.txtFiltar_aula.Name = "txtFiltar_aula";
            this.txtFiltar_aula.Size = new System.Drawing.Size(139, 20);
            this.txtFiltar_aula.TabIndex = 64;
            this.txtFiltar_aula.TextChanged += new System.EventHandler(this.txtFiltar_aula_TextChanged);
            // 
            // frmAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(809, 220);
            this.Controls.Add(this.lbxBuscarAula);
            this.Controls.Add(this.txtFiltar_aula);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dgvAula);
            this.Controls.Add(this.txtAula_descripcion);
            this.Controls.Add(this.label1);
            this.Name = "frmAula";
            this.Text = "frmAula";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAula_FormClosing);
            this.Load += new System.EventHandler(this.frmAula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dgvAula;
        private System.Windows.Forms.TextBox txtAula_descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ListBox lbxBuscarAula;
        private System.Windows.Forms.TextBox txtFiltar_aula;
    }
}