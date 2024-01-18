
namespace MarketManager.Presentacion
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.panel_superior = new System.Windows.Forms.Panel();
            this.fecha = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_usuario = new FontAwesome.Sharp.IconButton();
            this.barra_lateral = new System.Windows.Forms.Panel();
            this.bt_acerca = new FontAwesome.Sharp.IconButton();
            this.bt_usuarios = new FontAwesome.Sharp.IconButton();
            this.panel_inventario = new System.Windows.Forms.Panel();
            this.bt_sub_movimientos = new FontAwesome.Sharp.IconButton();
            this.bt_sub_productos = new FontAwesome.Sharp.IconButton();
            this.bt_inventario = new FontAwesome.Sharp.IconButton();
            this.bt_proveedores = new FontAwesome.Sharp.IconButton();
            this.panel_reportes = new System.Windows.Forms.Panel();
            this.bt_sub_compras = new FontAwesome.Sharp.IconButton();
            this.bt_sub_ventas = new FontAwesome.Sharp.IconButton();
            this.bt_reportes = new FontAwesome.Sharp.IconButton();
            this.bt_clientes = new FontAwesome.Sharp.IconButton();
            this.bt_empleados = new FontAwesome.Sharp.IconButton();
            this.bt_compra = new FontAwesome.Sharp.IconButton();
            this.bt_venta = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fechahora = new System.Windows.Forms.Timer(this.components);
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.panel_perfil = new System.Windows.Forms.Panel();
            this.bt_cerrar = new FontAwesome.Sharp.IconButton();
            this.bt_perfil = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.barra_lateral.SuspendLayout();
            this.panel_inventario.SuspendLayout();
            this.panel_reportes.SuspendLayout();
            this.panel_contenedor.SuspendLayout();
            this.panel_perfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_superior
            // 
            this.panel_superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.panel_superior.Controls.Add(this.fecha);
            this.panel_superior.Controls.Add(this.hora);
            this.panel_superior.Controls.Add(this.titulo);
            this.panel_superior.Controls.Add(this.pictureBox1);
            this.panel_superior.Controls.Add(this.bt_usuario);
            this.panel_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_superior.Location = new System.Drawing.Point(0, 0);
            this.panel_superior.Name = "panel_superior";
            this.panel_superior.Size = new System.Drawing.Size(1084, 62);
            this.panel_superior.TabIndex = 1;
            // 
            // fecha
            // 
            this.fecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.fecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fecha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.ForeColor = System.Drawing.Color.LightGray;
            this.fecha.Location = new System.Drawing.Point(261, 0);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(642, 29);
            this.fecha.TabIndex = 6;
            this.fecha.Text = "Fecha";
            this.fecha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fecha.Click += new System.EventHandler(this.fecha_Click);
            // 
            // hora
            // 
            this.hora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.hora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hora.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.ForeColor = System.Drawing.Color.LightGray;
            this.hora.Location = new System.Drawing.Point(261, 37);
            this.hora.Margin = new System.Windows.Forms.Padding(5);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(642, 25);
            this.hora.TabIndex = 5;
            this.hora.Text = "Hora";
            this.hora.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titulo
            // 
            this.titulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.titulo.Font = new System.Drawing.Font("Cooper Black", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.titulo.Location = new System.Drawing.Point(63, 0);
            this.titulo.Margin = new System.Windows.Forms.Padding(0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(198, 62);
            this.titulo.TabIndex = 4;
            this.titulo.Text = "MarketManager";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titulo.Click += new System.EventHandler(this.titulo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(63, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bt_usuario
            // 
            this.bt_usuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_usuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.bt_usuario.FlatAppearance.BorderSize = 0;
            this.bt_usuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.bt_usuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.bt_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_usuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_usuario.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            this.bt_usuario.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bt_usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_usuario.IconSize = 20;
            this.bt_usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_usuario.Location = new System.Drawing.Point(903, 0);
            this.bt_usuario.Margin = new System.Windows.Forms.Padding(0);
            this.bt_usuario.Name = "bt_usuario";
            this.bt_usuario.Size = new System.Drawing.Size(181, 62);
            this.bt_usuario.TabIndex = 8;
            this.bt_usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_usuario.UseVisualStyleBackColor = false;
            this.bt_usuario.Click += new System.EventHandler(this.bt_usuario_Click);
            this.bt_usuario.MouseEnter += new System.EventHandler(this.bt_usuario_MouseEnter);
            this.bt_usuario.MouseLeave += new System.EventHandler(this.bt_usuario_MouseLeave);
            // 
            // barra_lateral
            // 
            this.barra_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.barra_lateral.Controls.Add(this.bt_acerca);
            this.barra_lateral.Controls.Add(this.bt_usuarios);
            this.barra_lateral.Controls.Add(this.panel_inventario);
            this.barra_lateral.Controls.Add(this.bt_inventario);
            this.barra_lateral.Controls.Add(this.bt_proveedores);
            this.barra_lateral.Controls.Add(this.panel_reportes);
            this.barra_lateral.Controls.Add(this.bt_reportes);
            this.barra_lateral.Controls.Add(this.bt_clientes);
            this.barra_lateral.Controls.Add(this.bt_empleados);
            this.barra_lateral.Controls.Add(this.bt_compra);
            this.barra_lateral.Controls.Add(this.bt_venta);
            this.barra_lateral.Controls.Add(this.panel1);
            this.barra_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.barra_lateral.Location = new System.Drawing.Point(0, 62);
            this.barra_lateral.Name = "barra_lateral";
            this.barra_lateral.Size = new System.Drawing.Size(261, 619);
            this.barra_lateral.TabIndex = 2;
            // 
            // bt_acerca
            // 
            this.bt_acerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bt_acerca.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_acerca.FlatAppearance.BorderSize = 0;
            this.bt_acerca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.bt_acerca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_acerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_acerca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_acerca.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_acerca.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.bt_acerca.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bt_acerca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_acerca.IconSize = 40;
            this.bt_acerca.Location = new System.Drawing.Point(0, 574);
            this.bt_acerca.Name = "bt_acerca";
            this.bt_acerca.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_acerca.Size = new System.Drawing.Size(261, 45);
            this.bt_acerca.TabIndex = 12;
            this.bt_acerca.Text = "Acerca de";
            this.bt_acerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_acerca.UseVisualStyleBackColor = false;
            this.bt_acerca.Click += new System.EventHandler(this.bt_acerca_Click);
            // 
            // bt_usuarios
            // 
            this.bt_usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bt_usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_usuarios.FlatAppearance.BorderSize = 0;
            this.bt_usuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.bt_usuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_usuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_usuarios.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_usuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.bt_usuarios.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bt_usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_usuarios.IconSize = 40;
            this.bt_usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_usuarios.Location = new System.Drawing.Point(0, 521);
            this.bt_usuarios.Name = "bt_usuarios";
            this.bt_usuarios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_usuarios.Size = new System.Drawing.Size(261, 45);
            this.bt_usuarios.TabIndex = 11;
            this.bt_usuarios.Text = "Usuarios";
            this.bt_usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_usuarios.UseVisualStyleBackColor = false;
            this.bt_usuarios.Click += new System.EventHandler(this.bt_usuarios_Click);
            // 
            // panel_inventario
            // 
            this.panel_inventario.BackColor = System.Drawing.Color.MintCream;
            this.panel_inventario.Controls.Add(this.bt_sub_movimientos);
            this.panel_inventario.Controls.Add(this.bt_sub_productos);
            this.panel_inventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_inventario.Location = new System.Drawing.Point(0, 431);
            this.panel_inventario.Name = "panel_inventario";
            this.panel_inventario.Size = new System.Drawing.Size(261, 90);
            this.panel_inventario.TabIndex = 9;
            // 
            // bt_sub_movimientos
            // 
            this.bt_sub_movimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.bt_sub_movimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_sub_movimientos.FlatAppearance.BorderSize = 0;
            this.bt_sub_movimientos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.bt_sub_movimientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(184)))));
            this.bt_sub_movimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sub_movimientos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sub_movimientos.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_sub_movimientos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bt_sub_movimientos.IconColor = System.Drawing.Color.Black;
            this.bt_sub_movimientos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_sub_movimientos.IconSize = 40;
            this.bt_sub_movimientos.Location = new System.Drawing.Point(0, 45);
            this.bt_sub_movimientos.Name = "bt_sub_movimientos";
            this.bt_sub_movimientos.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.bt_sub_movimientos.Size = new System.Drawing.Size(261, 45);
            this.bt_sub_movimientos.TabIndex = 1;
            this.bt_sub_movimientos.Text = "Movimientos";
            this.bt_sub_movimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sub_movimientos.UseVisualStyleBackColor = false;
            this.bt_sub_movimientos.Click += new System.EventHandler(this.bt_sub_movimientos_Click);
            // 
            // bt_sub_productos
            // 
            this.bt_sub_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.bt_sub_productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_sub_productos.FlatAppearance.BorderSize = 0;
            this.bt_sub_productos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.bt_sub_productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(184)))));
            this.bt_sub_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sub_productos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sub_productos.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_sub_productos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bt_sub_productos.IconColor = System.Drawing.Color.Black;
            this.bt_sub_productos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_sub_productos.IconSize = 40;
            this.bt_sub_productos.Location = new System.Drawing.Point(0, 0);
            this.bt_sub_productos.Name = "bt_sub_productos";
            this.bt_sub_productos.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.bt_sub_productos.Size = new System.Drawing.Size(261, 45);
            this.bt_sub_productos.TabIndex = 0;
            this.bt_sub_productos.Text = "Productos";
            this.bt_sub_productos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sub_productos.UseVisualStyleBackColor = false;
            this.bt_sub_productos.Click += new System.EventHandler(this.bt_sub_productos_Click);
            // 
            // bt_inventario
            // 
            this.bt_inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bt_inventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_inventario.FlatAppearance.BorderSize = 0;
            this.bt_inventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.bt_inventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_inventario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_inventario.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_inventario.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.bt_inventario.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bt_inventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_inventario.IconSize = 40;
            this.bt_inventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_inventario.Location = new System.Drawing.Point(0, 386);
            this.bt_inventario.Name = "bt_inventario";
            this.bt_inventario.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_inventario.Size = new System.Drawing.Size(261, 45);
            this.bt_inventario.TabIndex = 8;
            this.bt_inventario.Text = "Inventario";
            this.bt_inventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_inventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_inventario.UseVisualStyleBackColor = false;
            this.bt_inventario.Click += new System.EventHandler(this.bt_inventario_Click);
            // 
            // bt_proveedores
            // 
            this.bt_proveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bt_proveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_proveedores.FlatAppearance.BorderSize = 0;
            this.bt_proveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.bt_proveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_proveedores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_proveedores.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_proveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.bt_proveedores.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bt_proveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_proveedores.IconSize = 40;
            this.bt_proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_proveedores.Location = new System.Drawing.Point(0, 341);
            this.bt_proveedores.Name = "bt_proveedores";
            this.bt_proveedores.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_proveedores.Size = new System.Drawing.Size(261, 45);
            this.bt_proveedores.TabIndex = 7;
            this.bt_proveedores.Text = "Proveedores";
            this.bt_proveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_proveedores.UseVisualStyleBackColor = false;
            this.bt_proveedores.Click += new System.EventHandler(this.bt_proveedores_Click);
            // 
            // panel_reportes
            // 
            this.panel_reportes.BackColor = System.Drawing.Color.MintCream;
            this.panel_reportes.Controls.Add(this.bt_sub_compras);
            this.panel_reportes.Controls.Add(this.bt_sub_ventas);
            this.panel_reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_reportes.Location = new System.Drawing.Point(0, 251);
            this.panel_reportes.Name = "panel_reportes";
            this.panel_reportes.Size = new System.Drawing.Size(261, 90);
            this.panel_reportes.TabIndex = 6;
            // 
            // bt_sub_compras
            // 
            this.bt_sub_compras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.bt_sub_compras.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_sub_compras.FlatAppearance.BorderSize = 0;
            this.bt_sub_compras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.bt_sub_compras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(184)))));
            this.bt_sub_compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sub_compras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sub_compras.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_sub_compras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bt_sub_compras.IconColor = System.Drawing.Color.Black;
            this.bt_sub_compras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_sub_compras.IconSize = 40;
            this.bt_sub_compras.Location = new System.Drawing.Point(0, 45);
            this.bt_sub_compras.Name = "bt_sub_compras";
            this.bt_sub_compras.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.bt_sub_compras.Size = new System.Drawing.Size(261, 45);
            this.bt_sub_compras.TabIndex = 1;
            this.bt_sub_compras.Text = "Compras";
            this.bt_sub_compras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sub_compras.UseVisualStyleBackColor = false;
            this.bt_sub_compras.Click += new System.EventHandler(this.bt_sub_compras_Click);
            // 
            // bt_sub_ventas
            // 
            this.bt_sub_ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.bt_sub_ventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_sub_ventas.FlatAppearance.BorderSize = 0;
            this.bt_sub_ventas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.bt_sub_ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(184)))));
            this.bt_sub_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sub_ventas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sub_ventas.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_sub_ventas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bt_sub_ventas.IconColor = System.Drawing.Color.Black;
            this.bt_sub_ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_sub_ventas.IconSize = 40;
            this.bt_sub_ventas.Location = new System.Drawing.Point(0, 0);
            this.bt_sub_ventas.Name = "bt_sub_ventas";
            this.bt_sub_ventas.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.bt_sub_ventas.Size = new System.Drawing.Size(261, 45);
            this.bt_sub_ventas.TabIndex = 0;
            this.bt_sub_ventas.Text = "Ventas";
            this.bt_sub_ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sub_ventas.UseVisualStyleBackColor = false;
            this.bt_sub_ventas.Click += new System.EventHandler(this.bt_sub_ventas_Click);
            // 
            // bt_reportes
            // 
            this.bt_reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bt_reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_reportes.FlatAppearance.BorderSize = 0;
            this.bt_reportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.bt_reportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_reportes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reportes.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_reportes.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.bt_reportes.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bt_reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_reportes.IconSize = 40;
            this.bt_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_reportes.Location = new System.Drawing.Point(0, 206);
            this.bt_reportes.Name = "bt_reportes";
            this.bt_reportes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_reportes.Size = new System.Drawing.Size(261, 45);
            this.bt_reportes.TabIndex = 5;
            this.bt_reportes.Text = "Reportes";
            this.bt_reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_reportes.UseVisualStyleBackColor = false;
            this.bt_reportes.Click += new System.EventHandler(this.bt_reportes_Click);
            // 
            // bt_clientes
            // 
            this.bt_clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bt_clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_clientes.FlatAppearance.BorderSize = 0;
            this.bt_clientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.bt_clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_clientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clientes.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_clientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.bt_clientes.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bt_clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_clientes.IconSize = 40;
            this.bt_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_clientes.Location = new System.Drawing.Point(0, 161);
            this.bt_clientes.Name = "bt_clientes";
            this.bt_clientes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_clientes.Size = new System.Drawing.Size(261, 45);
            this.bt_clientes.TabIndex = 4;
            this.bt_clientes.Text = "Clientes";
            this.bt_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_clientes.UseVisualStyleBackColor = false;
            this.bt_clientes.Click += new System.EventHandler(this.bt_clientes_Click);
            // 
            // bt_empleados
            // 
            this.bt_empleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bt_empleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_empleados.FlatAppearance.BorderSize = 0;
            this.bt_empleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.bt_empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_empleados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_empleados.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_empleados.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.bt_empleados.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bt_empleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_empleados.IconSize = 40;
            this.bt_empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_empleados.Location = new System.Drawing.Point(0, 116);
            this.bt_empleados.Name = "bt_empleados";
            this.bt_empleados.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_empleados.Size = new System.Drawing.Size(261, 45);
            this.bt_empleados.TabIndex = 3;
            this.bt_empleados.Text = "Empleados";
            this.bt_empleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_empleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_empleados.UseVisualStyleBackColor = false;
            this.bt_empleados.Click += new System.EventHandler(this.bt_empleados_Click);
            // 
            // bt_compra
            // 
            this.bt_compra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bt_compra.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_compra.FlatAppearance.BorderSize = 0;
            this.bt_compra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.bt_compra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_compra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_compra.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_compra.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.bt_compra.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bt_compra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_compra.IconSize = 40;
            this.bt_compra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_compra.Location = new System.Drawing.Point(0, 71);
            this.bt_compra.Margin = new System.Windows.Forms.Padding(0);
            this.bt_compra.Name = "bt_compra";
            this.bt_compra.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_compra.Size = new System.Drawing.Size(261, 45);
            this.bt_compra.TabIndex = 2;
            this.bt_compra.Text = "Compra";
            this.bt_compra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_compra.UseVisualStyleBackColor = false;
            this.bt_compra.Click += new System.EventHandler(this.bt_compra_Click);
            // 
            // bt_venta
            // 
            this.bt_venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bt_venta.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_venta.FlatAppearance.BorderSize = 0;
            this.bt_venta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.bt_venta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_venta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_venta.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_venta.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.bt_venta.IconColor = System.Drawing.Color.WhiteSmoke;
            this.bt_venta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_venta.IconSize = 40;
            this.bt_venta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_venta.Location = new System.Drawing.Point(0, 26);
            this.bt_venta.Margin = new System.Windows.Forms.Padding(0);
            this.bt_venta.Name = "bt_venta";
            this.bt_venta.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_venta.Size = new System.Drawing.Size(261, 45);
            this.bt_venta.TabIndex = 1;
            this.bt_venta.Text = "Venta";
            this.bt_venta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_venta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_venta.UseVisualStyleBackColor = false;
            this.bt_venta.Click += new System.EventHandler(this.bt_venta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 26);
            this.panel1.TabIndex = 0;
            // 
            // fechahora
            // 
            this.fechahora.Enabled = true;
            this.fechahora.Tick += new System.EventHandler(this.fechahora_Tick);
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_contenedor.Controls.Add(this.panel_perfil);
            this.panel_contenedor.Location = new System.Drawing.Point(261, 62);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(823, 619);
            this.panel_contenedor.TabIndex = 3;
            this.panel_contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_contenedor_Paint);
            // 
            // panel_perfil
            // 
            this.panel_perfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_perfil.Controls.Add(this.bt_cerrar);
            this.panel_perfil.Controls.Add(this.bt_perfil);
            this.panel_perfil.Location = new System.Drawing.Point(644, 0);
            this.panel_perfil.Name = "panel_perfil";
            this.panel_perfil.Size = new System.Drawing.Size(179, 90);
            this.panel_perfil.TabIndex = 2;
            // 
            // bt_cerrar
            // 
            this.bt_cerrar.BackColor = System.Drawing.Color.Navy;
            this.bt_cerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_cerrar.FlatAppearance.BorderSize = 0;
            this.bt_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.bt_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cerrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cerrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_cerrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bt_cerrar.IconColor = System.Drawing.Color.Black;
            this.bt_cerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_cerrar.Location = new System.Drawing.Point(0, 45);
            this.bt_cerrar.Name = "bt_cerrar";
            this.bt_cerrar.Size = new System.Drawing.Size(179, 45);
            this.bt_cerrar.TabIndex = 2;
            this.bt_cerrar.Text = "Cerrar Sesión";
            this.bt_cerrar.UseVisualStyleBackColor = false;
            this.bt_cerrar.Click += new System.EventHandler(this.bt_cerrar_Click);
            this.bt_cerrar.MouseEnter += new System.EventHandler(this.bt_cerrar_MouseEnter);
            this.bt_cerrar.MouseLeave += new System.EventHandler(this.bt_cerrar_MouseLeave);
            // 
            // bt_perfil
            // 
            this.bt_perfil.BackColor = System.Drawing.Color.Navy;
            this.bt_perfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_perfil.FlatAppearance.BorderSize = 0;
            this.bt_perfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.bt_perfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_perfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_perfil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_perfil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_perfil.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bt_perfil.IconColor = System.Drawing.Color.Black;
            this.bt_perfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_perfil.Location = new System.Drawing.Point(0, 0);
            this.bt_perfil.Name = "bt_perfil";
            this.bt_perfil.Size = new System.Drawing.Size(179, 45);
            this.bt_perfil.TabIndex = 0;
            this.bt_perfil.Text = "Perfil";
            this.bt_perfil.UseVisualStyleBackColor = false;
            this.bt_perfil.MouseEnter += new System.EventHandler(this.bt_perfil_MouseEnter);
            this.bt_perfil.MouseLeave += new System.EventHandler(this.bt_perfil_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.barra_lateral);
            this.Controls.Add(this.panel_superior);
            this.MinimumSize = new System.Drawing.Size(1100, 720);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panel_superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.barra_lateral.ResumeLayout(false);
            this.panel_inventario.ResumeLayout(false);
            this.panel_reportes.ResumeLayout(false);
            this.panel_contenedor.ResumeLayout(false);
            this.panel_perfil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_superior;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Panel barra_lateral;
        private FontAwesome.Sharp.IconButton bt_acerca;
        private FontAwesome.Sharp.IconButton bt_usuarios;
        private System.Windows.Forms.Panel panel_inventario;
        private FontAwesome.Sharp.IconButton bt_sub_movimientos;
        private FontAwesome.Sharp.IconButton bt_sub_productos;
        private FontAwesome.Sharp.IconButton bt_inventario;
        private FontAwesome.Sharp.IconButton bt_proveedores;
        private System.Windows.Forms.Panel panel_reportes;
        private FontAwesome.Sharp.IconButton bt_sub_compras;
        private FontAwesome.Sharp.IconButton bt_sub_ventas;
        private FontAwesome.Sharp.IconButton bt_reportes;
        private FontAwesome.Sharp.IconButton bt_clientes;
        private FontAwesome.Sharp.IconButton bt_empleados;
        private FontAwesome.Sharp.IconButton bt_compra;
        private FontAwesome.Sharp.IconButton bt_venta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer fechahora;
        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton bt_usuario;
        private System.Windows.Forms.Panel panel_perfil;
        private FontAwesome.Sharp.IconButton bt_cerrar;
        private FontAwesome.Sharp.IconButton bt_perfil;
        private System.Windows.Forms.Timer timer1;
    }
}