namespace CapaPresentacion
{
    partial class frmGrupo
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
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtGrupo_descripcion = new System.Windows.Forms.TextBox();
            this.dgvGrupo = new System.Windows.Forms.DataGridView();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbxBuscarGrupo = new System.Windows.Forms.ListBox();
            this.txtFiltar_gupo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción:";
            // 
            // txtGrupo_descripcion
            // 
            this.txtGrupo_descripcion.Location = new System.Drawing.Point(114, 58);
            this.txtGrupo_descripcion.Name = "txtGrupo_descripcion";
            this.txtGrupo_descripcion.Size = new System.Drawing.Size(143, 20);
            this.txtGrupo_descripcion.TabIndex = 1;
            // 
            // dgvGrupo
            // 
            this.dgvGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupo.Location = new System.Drawing.Point(338, 34);
            this.dgvGrupo.Name = "dgvGrupo";
            this.dgvGrupo.Size = new System.Drawing.Size(244, 150);
            this.dgvGrupo.TabIndex = 2;
            this.dgvGrupo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupo_CellClick);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(24, 154);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(86, 30);
            this.btnInsertar.TabIndex = 3;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(127, 154);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 30);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(232, 154);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 30);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Inactivar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // lbxBuscarGrupo
            // 
            this.lbxBuscarGrupo.FormattingEnabled = true;
            this.lbxBuscarGrupo.Location = new System.Drawing.Point(599, 34);
            this.lbxBuscarGrupo.Name = "lbxBuscarGrupo";
            this.lbxBuscarGrupo.Size = new System.Drawing.Size(180, 134);
            this.lbxBuscarGrupo.TabIndex = 65;
            this.lbxBuscarGrupo.SelectedIndexChanged += new System.EventHandler(this.lbxBuscarGrupo_SelectedIndexChanged);
            // 
            // txtFiltar_gupo
            // 
            this.txtFiltar_gupo.Location = new System.Drawing.Point(599, 190);
            this.txtFiltar_gupo.Name = "txtFiltar_gupo";
            this.txtFiltar_gupo.Size = new System.Drawing.Size(139, 20);
            this.txtFiltar_gupo.TabIndex = 64;
            this.txtFiltar_gupo.TextChanged += new System.EventHandler(this.txtFiltar_gupo_TextChanged);
            // 
            // frmGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(809, 235);
            this.Controls.Add(this.lbxBuscarGrupo);
            this.Controls.Add(this.txtFiltar_gupo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dgvGrupo);
            this.Controls.Add(this.txtGrupo_descripcion);
            this.Controls.Add(this.label1);
            this.Name = "frmGrupo";
            this.Text = "frmGrupo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGrupo_FormClosing);
            this.Load += new System.EventHandler(this.frmGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtGrupo_descripcion;
        private System.Windows.Forms.DataGridView dgvGrupo;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ListBox lbxBuscarGrupo;
        private System.Windows.Forms.TextBox txtFiltar_gupo;
    }
}