namespace PDBApp
{
    partial class FormConsultarClientes
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
            this.bttContacto = new System.Windows.Forms.Button();
            this.labelDG = new System.Windows.Forms.Label();
            this.labelCC = new System.Windows.Forms.Label();
            this.bttListaClientes = new System.Windows.Forms.Button();
            this.bttClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttContacto
            // 
            this.bttContacto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bttContacto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(25)))), ((int)(((byte)(42)))));
            this.bttContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttContacto.ForeColor = System.Drawing.Color.LightGray;
            this.bttContacto.Location = new System.Drawing.Point(366, 399);
            this.bttContacto.Margin = new System.Windows.Forms.Padding(4);
            this.bttContacto.Name = "bttContacto";
            this.bttContacto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bttContacto.Size = new System.Drawing.Size(130, 30);
            this.bttContacto.TabIndex = 16;
            this.bttContacto.Text = "Contacto empleados";
            this.bttContacto.UseVisualStyleBackColor = true;
            this.bttContacto.Click += new System.EventHandler(this.bttContacto_Click);
            // 
            // labelDG
            // 
            this.labelDG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDG.AutoSize = true;
            this.labelDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDG.ForeColor = System.Drawing.Color.LightGray;
            this.labelDG.Location = new System.Drawing.Point(9, 375);
            this.labelDG.Name = "labelDG";
            this.labelDG.Size = new System.Drawing.Size(273, 20);
            this.labelDG.TabIndex = 15;
            this.labelDG.Text = "Datos Generales de los Clientes:";
            // 
            // labelCC
            // 
            this.labelCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCC.AutoSize = true;
            this.labelCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCC.ForeColor = System.Drawing.Color.LightGray;
            this.labelCC.Location = new System.Drawing.Point(9, 351);
            this.labelCC.Name = "labelCC";
            this.labelCC.Size = new System.Drawing.Size(314, 24);
            this.labelCC.TabIndex = 13;
            this.labelCC.Text = "Datos a consultar de los Clientes";
            // 
            // bttListaClientes
            // 
            this.bttListaClientes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bttListaClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(25)))), ((int)(((byte)(42)))));
            this.bttListaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttListaClientes.ForeColor = System.Drawing.Color.LightGray;
            this.bttListaClientes.Location = new System.Drawing.Point(224, 399);
            this.bttListaClientes.Margin = new System.Windows.Forms.Padding(4);
            this.bttListaClientes.Name = "bttListaClientes";
            this.bttListaClientes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bttListaClientes.Size = new System.Drawing.Size(130, 30);
            this.bttListaClientes.TabIndex = 12;
            this.bttListaClientes.Text = "Listar Clientes";
            this.bttListaClientes.UseVisualStyleBackColor = true;
            this.bttListaClientes.Click += new System.EventHandler(this.bttListaClientes_Click);
            // 
            // bttClose
            // 
            this.bttClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(25)))), ((int)(((byte)(42)))));
            this.bttClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttClose.ForeColor = System.Drawing.Color.LightGray;
            this.bttClose.Location = new System.Drawing.Point(587, 519);
            this.bttClose.Margin = new System.Windows.Forms.Padding(4);
            this.bttClose.Name = "bttClose";
            this.bttClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bttClose.Size = new System.Drawing.Size(78, 30);
            this.bttClose.TabIndex = 11;
            this.bttClose.Text = "Cerrar";
            this.bttClose.UseVisualStyleBackColor = true;
            this.bttClose.Click += new System.EventHandler(this.bttClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(652, 323);
            this.dataGridView1.TabIndex = 17;
            // 
            // FormConsultarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttContacto);
            this.Controls.Add(this.labelDG);
            this.Controls.Add(this.labelCC);
            this.Controls.Add(this.bttListaClientes);
            this.Controls.Add(this.bttClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormConsultarClientes";
            this.Text = "FormConsultarClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttContacto;
        private System.Windows.Forms.Label labelDG;
        private System.Windows.Forms.Label labelCC;
        private System.Windows.Forms.Button bttListaClientes;
        private System.Windows.Forms.Button bttClose;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}