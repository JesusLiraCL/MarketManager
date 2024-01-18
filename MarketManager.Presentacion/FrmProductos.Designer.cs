
namespace MarketManager.Presentacion
{
    partial class FrmProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabla_productos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mostrador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_titulo = new System.Windows.Forms.Panel();
            this.agregar_producto = new FontAwesome.Sharp.IconButton();
            this.titulo = new System.Windows.Forms.Label();
            this.categorias = new System.Windows.Forms.ComboBox();
            this.panel_buscar = new System.Windows.Forms.Panel();
            this.buscar = new FontAwesome.Sharp.IconButton();
            this.textbox_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_productos)).BeginInit();
            this.panel_titulo.SuspendLayout();
            this.panel_buscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabla_productos
            // 
            this.tabla_productos.AllowUserToDeleteRows = false;
            this.tabla_productos.AllowUserToResizeColumns = false;
            this.tabla_productos.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.tabla_productos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.tabla_productos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabla_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_productos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabla_productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla_productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.tabla_productos.ColumnHeadersHeight = 30;
            this.tabla_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tabla_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.marca,
            this.categoria,
            this.mostrador,
            this.inventario});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_productos.DefaultCellStyle = dataGridViewCellStyle15;
            this.tabla_productos.EnableHeadersVisualStyles = false;
            this.tabla_productos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabla_productos.Location = new System.Drawing.Point(26, 188);
            this.tabla_productos.Name = "tabla_productos";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_productos.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.tabla_productos.RowHeadersWidth = 40;
            this.tabla_productos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tabla_productos.Size = new System.Drawing.Size(789, 404);
            this.tabla_productos.TabIndex = 1;
            this.tabla_productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_productos_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoría";
            this.categoria.Name = "categoria";
            // 
            // mostrador
            // 
            this.mostrador.HeaderText = "Mostrador";
            this.mostrador.Name = "mostrador";
            // 
            // inventario
            // 
            this.inventario.HeaderText = "Inventario";
            this.inventario.Name = "inventario";
            // 
            // panel_titulo
            // 
            this.panel_titulo.BackColor = System.Drawing.Color.Navy;
            this.panel_titulo.Controls.Add(this.agregar_producto);
            this.panel_titulo.Controls.Add(this.titulo);
            this.panel_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titulo.Location = new System.Drawing.Point(15, 30);
            this.panel_titulo.Name = "panel_titulo";
            this.panel_titulo.Size = new System.Drawing.Size(811, 64);
            this.panel_titulo.TabIndex = 4;
            // 
            // agregar_producto
            // 
            this.agregar_producto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.agregar_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.agregar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.agregar_producto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_producto.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.agregar_producto.IconColor = System.Drawing.Color.Black;
            this.agregar_producto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.agregar_producto.IconSize = 30;
            this.agregar_producto.Location = new System.Drawing.Point(611, 12);
            this.agregar_producto.Name = "agregar_producto";
            this.agregar_producto.Size = new System.Drawing.Size(188, 41);
            this.agregar_producto.TabIndex = 6;
            this.agregar_producto.Text = "Agregar Nuevo Producto";
            this.agregar_producto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.agregar_producto.UseVisualStyleBackColor = false;
            // 
            // titulo
            // 
            this.titulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.titulo.Font = new System.Drawing.Font("Cooper Black", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.titulo.Location = new System.Drawing.Point(0, 0);
            this.titulo.Margin = new System.Windows.Forms.Padding(0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(198, 64);
            this.titulo.TabIndex = 5;
            this.titulo.Text = "Productos";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categorias
            // 
            this.categorias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.categorias.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorias.FormattingEnabled = true;
            this.categorias.ItemHeight = 20;
            this.categorias.Items.AddRange(new object[] {
            "Alimentos No Perecederos",
            "Alimentos Perecederos",
            "Bebidas",
            "Charcutería",
            "Congelados",
            "Cuidados Para el Hogar",
            "Higiene y Cosméticos",
            "Lácteos",
            "Licores"});
            this.categorias.Location = new System.Drawing.Point(624, 141);
            this.categorias.Name = "categorias";
            this.categorias.Size = new System.Drawing.Size(191, 28);
            this.categorias.Sorted = true;
            this.categorias.TabIndex = 5;
            this.categorias.Text = "Categorías";
            // 
            // panel_buscar
            // 
            this.panel_buscar.Controls.Add(this.buscar);
            this.panel_buscar.Controls.Add(this.textbox_buscar);
            this.panel_buscar.Location = new System.Drawing.Point(26, 142);
            this.panel_buscar.Name = "panel_buscar";
            this.panel_buscar.Size = new System.Drawing.Size(270, 27);
            this.panel_buscar.TabIndex = 8;
            // 
            // buscar
            // 
            this.buscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.buscar.IconColor = System.Drawing.Color.Black;
            this.buscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buscar.IconSize = 20;
            this.buscar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buscar.Location = new System.Drawing.Point(238, 0);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(32, 27);
            this.buscar.TabIndex = 8;
            this.buscar.UseVisualStyleBackColor = true;
            // 
            // textbox_buscar
            // 
            this.textbox_buscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.textbox_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_buscar.Location = new System.Drawing.Point(0, 0);
            this.textbox_buscar.Name = "textbox_buscar";
            this.textbox_buscar.Size = new System.Drawing.Size(238, 27);
            this.textbox_buscar.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filtrar por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Buscar";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(15, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(811, 30);
            this.panel3.TabIndex = 92;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(826, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 716);
            this.panel5.TabIndex = 93;
            // 
            // panel17
            // 
            this.panel17.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(15, 716);
            this.panel17.TabIndex = 104;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 716);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_buscar);
            this.Controls.Add(this.categorias);
            this.Controls.Add(this.panel_titulo);
            this.Controls.Add(this.tabla_productos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_productos)).EndInit();
            this.panel_titulo.ResumeLayout(false);
            this.panel_buscar.ResumeLayout(false);
            this.panel_buscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tabla_productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn mostrador;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventario;
        private System.Windows.Forms.Panel panel_titulo;
        private FontAwesome.Sharp.IconButton agregar_producto;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.ComboBox categorias;
        private System.Windows.Forms.Panel panel_buscar;
        private FontAwesome.Sharp.IconButton buscar;
        private System.Windows.Forms.TextBox textbox_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel17;
    }
}