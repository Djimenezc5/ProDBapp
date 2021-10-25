
namespace PDBApp
{
    partial class Consulta_proveedores
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
            this.bttClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttContacto
            // 
            this.bttContacto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bttContacto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(25)))), ((int)(((byte)(42)))));
            this.bttContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttContacto.ForeColor = System.Drawing.Color.LightGray;
            this.bttContacto.Location = new System.Drawing.Point(275, 405);
            this.bttContacto.Margin = new System.Windows.Forms.Padding(5);
            this.bttContacto.Name = "bttContacto";
            this.bttContacto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bttContacto.Size = new System.Drawing.Size(161, 35);
            this.bttContacto.TabIndex = 22;
            this.bttContacto.Text = "Contacto proveedores";
            this.bttContacto.UseVisualStyleBackColor = true;
            this.bttContacto.Click += new System.EventHandler(this.bttContacto_Click);
            // 
            // labelDG
            // 
            this.labelDG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDG.AutoSize = true;
            this.labelDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDG.ForeColor = System.Drawing.Color.LightGray;
            this.labelDG.Location = new System.Drawing.Point(16, 364);
            this.labelDG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDG.Name = "labelDG";
            this.labelDG.Size = new System.Drawing.Size(308, 20);
            this.labelDG.TabIndex = 21;
            this.labelDG.Text = "Datos Generales de los Proveedores:";
            // 
            // labelCC
            // 
            this.labelCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCC.AutoSize = true;
            this.labelCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCC.ForeColor = System.Drawing.Color.LightGray;
            this.labelCC.Location = new System.Drawing.Point(15, 334);
            this.labelCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCC.Name = "labelCC";
            this.labelCC.Size = new System.Drawing.Size(358, 24);
            this.labelCC.TabIndex = 20;
            this.labelCC.Text = "Datos a consultar de los Proveedores";
            // 
            // bttClose
            // 
            this.bttClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(25)))), ((int)(((byte)(42)))));
            this.bttClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttClose.ForeColor = System.Drawing.Color.LightGray;
            this.bttClose.Location = new System.Drawing.Point(566, 518);
            this.bttClose.Margin = new System.Windows.Forms.Padding(5);
            this.bttClose.Name = "bttClose";
            this.bttClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bttClose.Size = new System.Drawing.Size(104, 29);
            this.bttClose.TabIndex = 18;
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
            this.dataGridView1.Location = new System.Drawing.Point(20, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(649, 314);
            this.dataGridView1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(25)))), ((int)(((byte)(42)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(446, 405);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(193, 35);
            this.button1.TabIndex = 23;
            this.button1.Text = "Producto de cada proveedor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(25)))), ((int)(((byte)(42)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(72, 405);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(193, 35);
            this.button2.TabIndex = 24;
            this.button2.Text = "Datos de cada proveedor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Consulta_proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttContacto);
            this.Controls.Add(this.labelDG);
            this.Controls.Add(this.labelCC);
            this.Controls.Add(this.bttClose);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Consulta_proveedores";
            this.Text = "Consulta_proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttContacto;
        private System.Windows.Forms.Label labelDG;
        private System.Windows.Forms.Label labelCC;
        private System.Windows.Forms.Button bttClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}