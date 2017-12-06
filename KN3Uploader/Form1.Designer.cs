namespace KN3Uploader
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.subirDesdePortapapelesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desdeArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desdePortapapelesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.capturarPantallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.abrirVentanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.FileCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer12 = new System.Timers.Timer();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copiarEnlaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirEnlaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.subirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desdePortapapelesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capturarPantallaCompletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarColaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarLinkstxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textoPlanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bBCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sonidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarMinimizadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timer12)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "kn3 Uploader";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subirDesdePortapapelesToolStripMenuItem,
            this.toolStripSeparator1,
            this.abrirVentanaToolStripMenuItem,
            this.toolStripSeparator2,
            this.salirToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(141, 82);
            // 
            // subirDesdePortapapelesToolStripMenuItem
            // 
            this.subirDesdePortapapelesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desdeArchivoToolStripMenuItem,
            this.desdePortapapelesToolStripMenuItem1,
            this.capturarPantallaToolStripMenuItem});
            this.subirDesdePortapapelesToolStripMenuItem.Name = "subirDesdePortapapelesToolStripMenuItem";
            this.subirDesdePortapapelesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.subirDesdePortapapelesToolStripMenuItem.Text = "Subir";
            // 
            // desdeArchivoToolStripMenuItem
            // 
            this.desdeArchivoToolStripMenuItem.Name = "desdeArchivoToolStripMenuItem";
            this.desdeArchivoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.desdeArchivoToolStripMenuItem.Text = "Desde Archivo";
            this.desdeArchivoToolStripMenuItem.Click += new System.EventHandler(this.desdeArchivoToolStripMenuItem_Click);
            // 
            // desdePortapapelesToolStripMenuItem1
            // 
            this.desdePortapapelesToolStripMenuItem1.Name = "desdePortapapelesToolStripMenuItem1";
            this.desdePortapapelesToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.desdePortapapelesToolStripMenuItem1.Text = "Desde portapapeles";
            this.desdePortapapelesToolStripMenuItem1.Click += new System.EventHandler(this.desdePortapapelesToolStripMenuItem1_Click);
            // 
            // capturarPantallaToolStripMenuItem
            // 
            this.capturarPantallaToolStripMenuItem.Name = "capturarPantallaToolStripMenuItem";
            this.capturarPantallaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.capturarPantallaToolStripMenuItem.Text = "Capturar Pantalla";
            this.capturarPantallaToolStripMenuItem.Click += new System.EventHandler(this.capturarPantallaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // abrirVentanaToolStripMenuItem
            // 
            this.abrirVentanaToolStripMenuItem.Name = "abrirVentanaToolStripMenuItem";
            this.abrirVentanaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.abrirVentanaToolStripMenuItem.Text = "Abrir ventana";
            this.abrirVentanaToolStripMenuItem.Click += new System.EventHandler(this.abrirVentanaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(137, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(12, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(627, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Subir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.Gray;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileCol,
            this.StatusCol});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(12, 106);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(627, 313);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // FileCol
            // 
            this.FileCol.Text = "Archivo";
            this.FileCol.Width = 285;
            // 
            // StatusCol
            // 
            this.StatusCol.Text = "Estado";
            this.StatusCol.Width = 339;
            // 
            // timer12
            // 
            this.timer12.Enabled = true;
            this.timer12.Interval = 500D;
            this.timer12.SynchronizingObject = this;
            this.timer12.Elapsed += new System.Timers.ElapsedEventHandler(this.timer12_Elapsed);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarEnlaceToolStripMenuItem,
            this.abrirEnlaceToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 48);
            // 
            // copiarEnlaceToolStripMenuItem
            // 
            this.copiarEnlaceToolStripMenuItem.Name = "copiarEnlaceToolStripMenuItem";
            this.copiarEnlaceToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.copiarEnlaceToolStripMenuItem.Text = "&Copiar Enlace";
            this.copiarEnlaceToolStripMenuItem.Click += new System.EventHandler(this.copiarEnlaceToolStripMenuItem_Click);
            // 
            // abrirEnlaceToolStripMenuItem
            // 
            this.abrirEnlaceToolStripMenuItem.Name = "abrirEnlaceToolStripMenuItem";
            this.abrirEnlaceToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.abrirEnlaceToolStripMenuItem.Text = "&Abrir Enlace";
            this.abrirEnlaceToolStripMenuItem.Click += new System.EventHandler(this.abrirEnlaceToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subirToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(651, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // subirToolStripMenuItem
            // 
            this.subirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desdePortapapelesToolStripMenuItem,
            this.capturarPantallaCompletaToolStripMenuItem});
            this.subirToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.subirToolStripMenuItem.Name = "subirToolStripMenuItem";
            this.subirToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.subirToolStripMenuItem.Text = "Subir";
            // 
            // desdePortapapelesToolStripMenuItem
            // 
            this.desdePortapapelesToolStripMenuItem.Name = "desdePortapapelesToolStripMenuItem";
            this.desdePortapapelesToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.desdePortapapelesToolStripMenuItem.Text = "Desde portapapeles";
            this.desdePortapapelesToolStripMenuItem.Click += new System.EventHandler(this.desdePortapapelesToolStripMenuItem_Click);
            // 
            // capturarPantallaCompletaToolStripMenuItem
            // 
            this.capturarPantallaCompletaToolStripMenuItem.Name = "capturarPantallaCompletaToolStripMenuItem";
            this.capturarPantallaCompletaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.capturarPantallaCompletaToolStripMenuItem.Text = "Capturar pantalla completa";
            this.capturarPantallaCompletaToolStripMenuItem.Click += new System.EventHandler(this.capturarPantallaCompletaToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limpiarColaToolStripMenuItem,
            this.mostrarLinkstxtToolStripMenuItem,
            this.sonidoToolStripMenuItem,
            this.iniciarMinimizadoToolStripMenuItem});
            this.opcionesToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // limpiarColaToolStripMenuItem
            // 
            this.limpiarColaToolStripMenuItem.Name = "limpiarColaToolStripMenuItem";
            this.limpiarColaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.limpiarColaToolStripMenuItem.Text = "&Limpiar cola";
            this.limpiarColaToolStripMenuItem.Click += new System.EventHandler(this.limpiarColaToolStripMenuItem_Click);
            // 
            // mostrarLinkstxtToolStripMenuItem
            // 
            this.mostrarLinkstxtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textoPlanoToolStripMenuItem,
            this.bBCodeToolStripMenuItem});
            this.mostrarLinkstxtToolStripMenuItem.Name = "mostrarLinkstxtToolStripMenuItem";
            this.mostrarLinkstxtToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.mostrarLinkstxtToolStripMenuItem.Text = "&Mostrar links";
            // 
            // textoPlanoToolStripMenuItem
            // 
            this.textoPlanoToolStripMenuItem.Name = "textoPlanoToolStripMenuItem";
            this.textoPlanoToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.textoPlanoToolStripMenuItem.Text = "Texto Plano";
            this.textoPlanoToolStripMenuItem.Click += new System.EventHandler(this.textoPlanoToolStripMenuItem_Click);
            // 
            // bBCodeToolStripMenuItem
            // 
            this.bBCodeToolStripMenuItem.Name = "bBCodeToolStripMenuItem";
            this.bBCodeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.bBCodeToolStripMenuItem.Text = "BBCode";
            this.bBCodeToolStripMenuItem.Click += new System.EventHandler(this.bBCodeToolStripMenuItem_Click);
            // 
            // sonidoToolStripMenuItem
            // 
            this.sonidoToolStripMenuItem.Checked = true;
            this.sonidoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sonidoToolStripMenuItem.Name = "sonidoToolStripMenuItem";
            this.sonidoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.sonidoToolStripMenuItem.Text = "Sonido";
            this.sonidoToolStripMenuItem.Click += new System.EventHandler(this.sonidoToolStripMenuItem_Click);
            // 
            // iniciarMinimizadoToolStripMenuItem
            // 
            this.iniciarMinimizadoToolStripMenuItem.Name = "iniciarMinimizadoToolStripMenuItem";
            this.iniciarMinimizadoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.iniciarMinimizadoToolStripMenuItem.Text = "Iniciar Minimizado";
            this.iniciarMinimizadoToolStripMenuItem.Click += new System.EventHandler(this.iniciarMinimizadoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(651, 431);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kn3 Uploader";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timer12)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader FileCol;
        private System.Windows.Forms.ColumnHeader StatusCol;
        private System.Timers.Timer timer12;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copiarEnlaceToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarColaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarLinkstxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textoPlanoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bBCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desdePortapapelesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capturarPantallaCompletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirEnlaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sonidoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem subirDesdePortapapelesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desdeArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desdePortapapelesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem capturarPantallaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem abrirVentanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem iniciarMinimizadoToolStripMenuItem;
    }
}

