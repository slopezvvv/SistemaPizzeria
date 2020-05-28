namespace Caja
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this._menu = new System.Windows.Forms.MenuStrip();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarCajaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tomarPedidoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarCajaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            MenuPrincipal._lblRutCajero = new System.Windows.Forms.Label();
            MenuPrincipal._lblNombreCajero = new System.Windows.Forms.Label();
            this._menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _menu
            // 
            this._menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem,
            this.accionesToolStripMenuItem});
            this._menu.Location = new System.Drawing.Point(0, 0);
            this._menu.Name = "_menu";
            this._menu.Size = new System.Drawing.Size(800, 24);
            this._menu.TabIndex = 0;
            this._menu.Text = "menuStrip1";
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarCajaToolStripMenuItem1,
            this.tomarPedidoToolStripMenuItem1,
            this.cerrarCajaToolStripMenuItem1});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // iniciarCajaToolStripMenuItem1
            // 
            this.iniciarCajaToolStripMenuItem1.Name = "iniciarCajaToolStripMenuItem1";
            this.iniciarCajaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.iniciarCajaToolStripMenuItem1.Text = "Iniciar caja";
            this.iniciarCajaToolStripMenuItem1.Click += new System.EventHandler(this.iniciarCajaToolStripMenuItem1_Click);
            // 
            // tomarPedidoToolStripMenuItem1
            // 
            this.tomarPedidoToolStripMenuItem1.Name = "tomarPedidoToolStripMenuItem1";
            this.tomarPedidoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.tomarPedidoToolStripMenuItem1.Text = "Tomar pedido";
            // 
            // cerrarCajaToolStripMenuItem1
            // 
            this.cerrarCajaToolStripMenuItem1.Name = "cerrarCajaToolStripMenuItem1";
            this.cerrarCajaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cerrarCajaToolStripMenuItem1.Text = "Cerrar caja";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // _lblRutCajero
            // 
            MenuPrincipal._lblRutCajero.AutoSize = true;
            MenuPrincipal._lblRutCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            MenuPrincipal._lblRutCajero.Location = new System.Drawing.Point(23, 49);
            MenuPrincipal._lblRutCajero.Name = "_lblRutCajero";
            MenuPrincipal._lblRutCajero.Size = new System.Drawing.Size(135, 25);
            MenuPrincipal._lblRutCajero.TabIndex = 1;
            MenuPrincipal._lblRutCajero.Text = "Caja cerrada";
            // 
            // _lblNombreCajero
            // 
            MenuPrincipal._lblNombreCajero.AutoSize = true;
            MenuPrincipal._lblNombreCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            MenuPrincipal._lblNombreCajero.Location = new System.Drawing.Point(23, 99);
            MenuPrincipal._lblNombreCajero.Name = "_lblNombreCajero";
            MenuPrincipal._lblNombreCajero.Size = new System.Drawing.Size(0, 25);
            MenuPrincipal._lblNombreCajero.TabIndex = 2;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(MenuPrincipal._lblNombreCajero);
            this.Controls.Add(MenuPrincipal._lblRutCajero);
            this.Controls.Add(this._menu);
            this.MainMenuStrip = this._menu;
            this.Name = "MenuPrincipal";
            this.Text = "Caja pizeria";
            this._menu.ResumeLayout(false);
            this._menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _menu;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarCajaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tomarPedidoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cerrarCajaToolStripMenuItem1;
        private static System.Windows.Forms.Label _lblRutCajero;
        private static System.Windows.Forms.Label _lblNombreCajero;
    }
}

