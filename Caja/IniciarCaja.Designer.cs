namespace Caja
{
    partial class IniciarCaja
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
            this._btnIngresar = new System.Windows.Forms.Button();
            this._lblRut = new System.Windows.Forms.Label();
            this._lblPass = new System.Windows.Forms.Label();
            this._txtRut = new System.Windows.Forms.TextBox();
            this._txtPass = new System.Windows.Forms.TextBox();
            this._lblGuion = new System.Windows.Forms.Label();
            this._txtDigito = new System.Windows.Forms.TextBox();
            this._btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnIngresar
            // 
            this._btnIngresar.Location = new System.Drawing.Point(21, 119);
            this._btnIngresar.Name = "_btnIngresar";
            this._btnIngresar.Size = new System.Drawing.Size(99, 39);
            this._btnIngresar.TabIndex = 0;
            this._btnIngresar.Text = "Iniciar sesión";
            this._btnIngresar.UseVisualStyleBackColor = true;
            this._btnIngresar.Click += new System.EventHandler(this._btnIngresar_Click);
            // 
            // _lblRut
            // 
            this._lblRut.AutoSize = true;
            this._lblRut.Location = new System.Drawing.Point(18, 32);
            this._lblRut.Name = "_lblRut";
            this._lblRut.Size = new System.Drawing.Size(27, 13);
            this._lblRut.TabIndex = 1;
            this._lblRut.Text = "Rut:";
            // 
            // _lblPass
            // 
            this._lblPass.AutoSize = true;
            this._lblPass.Location = new System.Drawing.Point(18, 65);
            this._lblPass.Name = "_lblPass";
            this._lblPass.Size = new System.Drawing.Size(64, 13);
            this._lblPass.TabIndex = 2;
            this._lblPass.Text = "Contraseña:";
            // 
            // _txtRut
            // 
            this._txtRut.Location = new System.Drawing.Point(129, 24);
            this._txtRut.Name = "_txtRut";
            this._txtRut.Size = new System.Drawing.Size(67, 20);
            this._txtRut.TabIndex = 3;
            // 
            // _txtPass
            // 
            this._txtPass.Location = new System.Drawing.Point(129, 65);
            this._txtPass.Name = "_txtPass";
            this._txtPass.PasswordChar = '*';
            this._txtPass.Size = new System.Drawing.Size(112, 20);
            this._txtPass.TabIndex = 4;
            // 
            // _lblGuion
            // 
            this._lblGuion.AutoSize = true;
            this._lblGuion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblGuion.Location = new System.Drawing.Point(202, 21);
            this._lblGuion.Name = "_lblGuion";
            this._lblGuion.Size = new System.Drawing.Size(16, 24);
            this._lblGuion.TabIndex = 5;
            this._lblGuion.Text = "-";
            // 
            // _txtDigito
            // 
            this._txtDigito.Location = new System.Drawing.Point(218, 25);
            this._txtDigito.Name = "_txtDigito";
            this._txtDigito.Size = new System.Drawing.Size(23, 20);
            this._txtDigito.TabIndex = 6;
            // 
            // _btnCancelar
            // 
            this._btnCancelar.Location = new System.Drawing.Point(144, 119);
            this._btnCancelar.Name = "_btnCancelar";
            this._btnCancelar.Size = new System.Drawing.Size(97, 38);
            this._btnCancelar.TabIndex = 7;
            this._btnCancelar.Text = "Cancelar";
            this._btnCancelar.UseVisualStyleBackColor = true;
            this._btnCancelar.Click += new System.EventHandler(this._btnCancelar_Click);
            // 
            // IniciarCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 193);
            this.ControlBox = false;
            this.Controls.Add(this._btnCancelar);
            this.Controls.Add(this._txtDigito);
            this.Controls.Add(this._lblGuion);
            this.Controls.Add(this._txtPass);
            this.Controls.Add(this._txtRut);
            this.Controls.Add(this._lblPass);
            this.Controls.Add(this._lblRut);
            this.Controls.Add(this._btnIngresar);
            this.Name = "IniciarCaja";
            this.Text = "Iniciar caja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnIngresar;
        private System.Windows.Forms.Label _lblRut;
        private System.Windows.Forms.Label _lblPass;
        private System.Windows.Forms.TextBox _txtRut;
        private System.Windows.Forms.TextBox _txtPass;
        private System.Windows.Forms.Label _lblGuion;
        private System.Windows.Forms.TextBox _txtDigito;
        private System.Windows.Forms.Button _btnCancelar;
    }
}