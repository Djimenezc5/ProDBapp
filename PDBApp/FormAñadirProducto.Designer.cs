namespace PDBApp
{
    partial class FormAñadirProducto
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
            this.cbEstatus = new System.Windows.Forms.ComboBox();
            this.cbIDproveedo = new System.Windows.Forms.ComboBox();
            this.bttClose = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbDescProd = new System.Windows.Forms.TextBox();
            this.bttAceptar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labeRE = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbEstatus
            // 
            this.cbEstatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbEstatus.FormattingEnabled = true;
            this.cbEstatus.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbEstatus.Location = new System.Drawing.Point(343, 343);
            this.cbEstatus.Name = "cbEstatus";
            this.cbEstatus.Size = new System.Drawing.Size(229, 24);
            this.cbEstatus.TabIndex = 112;
            // 
            // cbIDproveedo
            // 
            this.cbIDproveedo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbIDproveedo.FormattingEnabled = true;
            this.cbIDproveedo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbIDproveedo.Location = new System.Drawing.Point(343, 206);
            this.cbIDproveedo.Name = "cbIDproveedo";
            this.cbIDproveedo.Size = new System.Drawing.Size(229, 24);
            this.cbIDproveedo.TabIndex = 110;
            // 
            // bttClose
            // 
            this.bttClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(25)))), ((int)(((byte)(42)))));
            this.bttClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttClose.ForeColor = System.Drawing.Color.LightGray;
            this.bttClose.Location = new System.Drawing.Point(611, 518);
            this.bttClose.Margin = new System.Windows.Forms.Padding(4);
            this.bttClose.Name = "bttClose";
            this.bttClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bttClose.Size = new System.Drawing.Size(60, 30);
            this.bttClose.TabIndex = 108;
            this.bttClose.Text = "Cerrar";
            this.bttClose.UseVisualStyleBackColor = true;
            this.bttClose.Click += new System.EventHandler(this.bttClose_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombre.Location = new System.Drawing.Point(343, 274);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(229, 23);
            this.tbNombre.TabIndex = 107;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightGray;
            this.label12.Location = new System.Drawing.Point(261, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 106;
            this.label12.Text = "Nombre:";
            // 
            // tbDescProd
            // 
            this.tbDescProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDescProd.Location = new System.Drawing.Point(343, 310);
            this.tbDescProd.Name = "tbDescProd";
            this.tbDescProd.Size = new System.Drawing.Size(229, 23);
            this.tbDescProd.TabIndex = 104;
            // 
            // bttAceptar
            // 
            this.bttAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(25)))), ((int)(((byte)(42)))));
            this.bttAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAceptar.ForeColor = System.Drawing.Color.LightGray;
            this.bttAceptar.Location = new System.Drawing.Point(494, 376);
            this.bttAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.bttAceptar.Name = "bttAceptar";
            this.bttAceptar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bttAceptar.Size = new System.Drawing.Size(78, 30);
            this.bttAceptar.TabIndex = 103;
            this.bttAceptar.Text = "Aceptar";
            this.bttAceptar.UseVisualStyleBackColor = true;
            this.bttAceptar.Click += new System.EventHandler(this.bttAceptar_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(155, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 20);
            this.label8.TabIndex = 102;
            this.label8.Text = "Estatus del producto:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(124, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 20);
            this.label6.TabIndex = 100;
            this.label6.Text = "Descripción del producto:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(273, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 99;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(157, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 98;
            this.label3.Text = "Codigo de proveedor:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(162, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 97;
            this.label2.Text = "Codigo del producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 24);
            this.label1.TabIndex = 96;
            this.label1.Text = "Ingrese los datos que se solicitan a continuación";
            // 
            // labeRE
            // 
            this.labeRE.AutoSize = true;
            this.labeRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeRE.ForeColor = System.Drawing.Color.LightGray;
            this.labeRE.Location = new System.Drawing.Point(12, 9);
            this.labeRE.Name = "labeRE";
            this.labeRE.Size = new System.Drawing.Size(283, 25);
            this.labeRE.TabIndex = 95;
            this.labeRE.Text = "Añadir un nuevo producto";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(343, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 23);
            this.textBox1.TabIndex = 113;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(343, 241);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 23);
            this.textBox2.TabIndex = 114;
            // 
            // FormAñadirProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbEstatus);
            this.Controls.Add(this.cbIDproveedo);
            this.Controls.Add(this.bttClose);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbDescProd);
            this.Controls.Add(this.bttAceptar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labeRE);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAñadirProducto";
            this.Text = "FormAñadirProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEstatus;
        private System.Windows.Forms.ComboBox cbIDproveedo;
        private System.Windows.Forms.Button bttClose;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbDescProd;
        private System.Windows.Forms.Button bttAceptar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeRE;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}