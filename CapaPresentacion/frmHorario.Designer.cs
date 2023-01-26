namespace CapaPresentacion
{
    partial class frmHorario
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
            this.txtHorario_horaFinal = new System.Windows.Forms.TextBox();
            this.txtHorario_horaInicio = new System.Windows.Forms.TextBox();
            this.txtHorario_dia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHorario_descripcion = new System.Windows.Forms.TextBox();
            this.dgvHorario = new System.Windows.Forms.DataGridView();
            this.btnInsertarHorario = new System.Windows.Forms.Button();
            this.btnModificarHorario = new System.Windows.Forms.Button();
            this.btnEliminarHorario = new System.Windows.Forms.Button();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbxBuscarHorario = new System.Windows.Forms.ListBox();
            this.txtFiltar_horario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHorario_horaFinal
            // 
            this.txtHorario_horaFinal.Location = new System.Drawing.Point(125, 169);
            this.txtHorario_horaFinal.Name = "txtHorario_horaFinal";
            this.txtHorario_horaFinal.Size = new System.Drawing.Size(139, 20);
            this.txtHorario_horaFinal.TabIndex = 64;
            // 
            // txtHorario_horaInicio
            // 
            this.txtHorario_horaInicio.Location = new System.Drawing.Point(125, 130);
            this.txtHorario_horaInicio.Name = "txtHorario_horaInicio";
            this.txtHorario_horaInicio.Size = new System.Drawing.Size(139, 20);
            this.txtHorario_horaInicio.TabIndex = 63;
            // 
            // txtHorario_dia
            // 
            this.txtHorario_dia.Location = new System.Drawing.Point(125, 92);
            this.txtHorario_dia.Name = "txtHorario_dia";
            this.txtHorario_dia.Size = new System.Drawing.Size(139, 20);
            this.txtHorario_dia.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 59;
            this.label5.Text = "Hora Final:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 58;
            this.label4.Text = "Hora Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 18);
            this.label3.TabIndex = 57;
            this.label3.Text = "Día:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 56;
            this.label2.Text = "Descripción:";
            // 
            // txtHorario_descripcion
            // 
            this.txtHorario_descripcion.Location = new System.Drawing.Point(125, 56);
            this.txtHorario_descripcion.Name = "txtHorario_descripcion";
            this.txtHorario_descripcion.Size = new System.Drawing.Size(139, 20);
            this.txtHorario_descripcion.TabIndex = 55;
            // 
            // dgvHorario
            // 
            this.dgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorario.Location = new System.Drawing.Point(291, 12);
            this.dgvHorario.Name = "dgvHorario";
            this.dgvHorario.Size = new System.Drawing.Size(424, 285);
            this.dgvHorario.TabIndex = 65;
            this.dgvHorario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorario_CellClick);
            // 
            // btnInsertarHorario
            // 
            this.btnInsertarHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarHorario.Location = new System.Drawing.Point(16, 232);
            this.btnInsertarHorario.Name = "btnInsertarHorario";
            this.btnInsertarHorario.Size = new System.Drawing.Size(101, 35);
            this.btnInsertarHorario.TabIndex = 66;
            this.btnInsertarHorario.Text = "Insertar";
            this.btnInsertarHorario.UseVisualStyleBackColor = true;
            this.btnInsertarHorario.Click += new System.EventHandler(this.btnInsertarHorario_Click);
            // 
            // btnModificarHorario
            // 
            this.btnModificarHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarHorario.Location = new System.Drawing.Point(146, 232);
            this.btnModificarHorario.Name = "btnModificarHorario";
            this.btnModificarHorario.Size = new System.Drawing.Size(101, 35);
            this.btnModificarHorario.TabIndex = 67;
            this.btnModificarHorario.Text = "Modificar";
            this.btnModificarHorario.UseVisualStyleBackColor = true;
            this.btnModificarHorario.Click += new System.EventHandler(this.btnModificarHorario_Click);
            // 
            // btnEliminarHorario
            // 
            this.btnEliminarHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarHorario.Location = new System.Drawing.Point(79, 295);
            this.btnEliminarHorario.Name = "btnEliminarHorario";
            this.btnEliminarHorario.Size = new System.Drawing.Size(101, 35);
            this.btnEliminarHorario.TabIndex = 68;
            this.btnEliminarHorario.Text = "Inactivar";
            this.btnEliminarHorario.UseVisualStyleBackColor = true;
            this.btnEliminarHorario.Click += new System.EventHandler(this.btnEliminarHorario_Click);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // lbxBuscarHorario
            // 
            this.lbxBuscarHorario.FormattingEnabled = true;
            this.lbxBuscarHorario.Location = new System.Drawing.Point(721, 16);
            this.lbxBuscarHorario.Name = "lbxBuscarHorario";
            this.lbxBuscarHorario.Size = new System.Drawing.Size(180, 134);
            this.lbxBuscarHorario.TabIndex = 69;
            this.lbxBuscarHorario.SelectedIndexChanged += new System.EventHandler(this.lbxBuscarHorario_SelectedIndexChanged);
            // 
            // txtFiltar_horario
            // 
            this.txtFiltar_horario.Location = new System.Drawing.Point(721, 169);
            this.txtFiltar_horario.Name = "txtFiltar_horario";
            this.txtFiltar_horario.Size = new System.Drawing.Size(139, 20);
            this.txtFiltar_horario.TabIndex = 70;
            this.txtFiltar_horario.TextChanged += new System.EventHandler(this.txtFiltar_horario_TextChanged);
            // 
            // frmHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(911, 372);
            this.Controls.Add(this.txtFiltar_horario);
            this.Controls.Add(this.lbxBuscarHorario);
            this.Controls.Add(this.btnEliminarHorario);
            this.Controls.Add(this.btnModificarHorario);
            this.Controls.Add(this.btnInsertarHorario);
            this.Controls.Add(this.dgvHorario);
            this.Controls.Add(this.txtHorario_horaFinal);
            this.Controls.Add(this.txtHorario_horaInicio);
            this.Controls.Add(this.txtHorario_dia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHorario_descripcion);
            this.Name = "frmHorario";
            this.Text = "frmHorario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHorario_FormClosing);
            this.Load += new System.EventHandler(this.frmHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtHorario_horaFinal;
        private System.Windows.Forms.TextBox txtHorario_horaInicio;
        private System.Windows.Forms.TextBox txtHorario_dia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHorario_descripcion;
        private System.Windows.Forms.DataGridView dgvHorario;
        private System.Windows.Forms.Button btnInsertarHorario;
        private System.Windows.Forms.Button btnModificarHorario;
        private System.Windows.Forms.Button btnEliminarHorario;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ListBox lbxBuscarHorario;
        private System.Windows.Forms.TextBox txtFiltar_horario;
    }
}