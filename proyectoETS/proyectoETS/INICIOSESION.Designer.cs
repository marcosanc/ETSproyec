namespace proyectoETS
{
    partial class Iniciosesion
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
            this.iniciar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textcon = new System.Windows.Forms.TextBox();
            this.textusu = new System.Windows.Forms.TextBox();
            this.REGISTRO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iniciar
            // 
            this.iniciar.Location = new System.Drawing.Point(15, 197);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(75, 23);
            this.iniciar.TabIndex = 0;
            this.iniciar.Text = "INICIAR";
            this.iniciar.UseVisualStyleBackColor = true;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(233, 197);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 1;
            this.salir.Text = "SALIR";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(67, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "INICIO DE SESIÓN ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "USUARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "CONTRASEÑA";
            // 
            // textcon
            // 
            this.textcon.Location = new System.Drawing.Point(134, 126);
            this.textcon.Name = "textcon";
            this.textcon.PasswordChar = '*';
            this.textcon.Size = new System.Drawing.Size(100, 20);
            this.textcon.TabIndex = 5;
            // 
            // textusu
            // 
            this.textusu.Location = new System.Drawing.Point(134, 76);
            this.textusu.Name = "textusu";
            this.textusu.Size = new System.Drawing.Size(100, 20);
            this.textusu.TabIndex = 6;
            // 
            // REGISTRO
            // 
            this.REGISTRO.Location = new System.Drawing.Point(120, 197);
            this.REGISTRO.Name = "REGISTRO";
            this.REGISTRO.Size = new System.Drawing.Size(75, 23);
            this.REGISTRO.TabIndex = 7;
            this.REGISTRO.Text = "REGISTRO";
            this.REGISTRO.UseVisualStyleBackColor = true;
            this.REGISTRO.Click += new System.EventHandler(this.button1_Click);
            // 
            // INICIOSESION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 249);
            this.Controls.Add(this.REGISTRO);
            this.Controls.Add(this.textusu);
            this.Controls.Add(this.textcon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.iniciar);
            this.Name = "INICIOSESION";
            this.Text = "INICIOSESION";
            this.Load += new System.EventHandler(this.INICIOSESION_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textcon;
        private System.Windows.Forms.TextBox textusu;
        private System.Windows.Forms.Button REGISTRO;
    }
}