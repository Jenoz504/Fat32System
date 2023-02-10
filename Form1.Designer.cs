
namespace Fat32System
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
            this.vistaArchivos = new System.Windows.Forms.ListView();
            this.ListaIconos = new System.Windows.Forms.ImageList(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTamanio = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnIr = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vistaArchivos
            // 
            this.vistaArchivos.HideSelection = false;
            this.vistaArchivos.LargeImageList = this.ListaIconos;
            this.vistaArchivos.Location = new System.Drawing.Point(131, 38);
            this.vistaArchivos.Name = "vistaArchivos";
            this.vistaArchivos.Size = new System.Drawing.Size(896, 383);
            this.vistaArchivos.SmallImageList = this.ListaIconos;
            this.vistaArchivos.TabIndex = 0;
            this.vistaArchivos.UseCompatibleStateImageBehavior = false;
            this.vistaArchivos.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.vistaArchivos_ItemSelectionChanged);
            this.vistaArchivos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.vistaArchivos_MouseDoubleClick);
            // 
            // ListaIconos
            // 
            this.ListaIconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListaIconos.ImageStream")));
            this.ListaIconos.TransparentColor = System.Drawing.Color.Transparent;
            this.ListaIconos.Images.SetKeyName(0, "folder.png");
            this.ListaIconos.Images.SetKeyName(1, "folder2.png");
            this.ListaIconos.Images.SetKeyName(2, "file.png");
            this.ListaIconos.Images.SetKeyName(3, "doc.png");
            this.ListaIconos.Images.SetKeyName(4, "pdf.png");
            this.ListaIconos.Images.SetKeyName(5, "mp3.png");
            this.ListaIconos.Images.SetKeyName(6, "mp4.png");
            this.ListaIconos.Images.SetKeyName(7, "exe.png");
            this.ListaIconos.Images.SetKeyName(8, "unknown.png");
            this.ListaIconos.Images.SetKeyName(9, "png.png");
            this.ListaIconos.Images.SetKeyName(10, "folder64.png");
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 381);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tamaño";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(254, 460);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(10, 13);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "-";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(72, 440);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(10, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "-";
            // 
            // lblTamanio
            // 
            this.lblTamanio.AutoSize = true;
            this.lblTamanio.Location = new System.Drawing.Point(72, 460);
            this.lblTamanio.Name = "lblTamanio";
            this.lblTamanio.Size = new System.Drawing.Size(10, 13);
            this.lblTamanio.TabIndex = 7;
            this.lblTamanio.Text = "-";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(79, 11);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(868, 20);
            this.txtDireccion.TabIndex = 8;
            // 
            // btnIr
            // 
            this.btnIr.Location = new System.Drawing.Point(960, 10);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(67, 23);
            this.btnIr.TabIndex = 9;
            this.btnIr.Text = "Buscar";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(6, 9);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(67, 23);
            this.btnAtras.TabIndex = 10;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 534);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblTamanio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.vistaArchivos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView vistaArchivos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTamanio;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.ImageList ListaIconos;
        private System.Windows.Forms.Button btnAtras;
    }
}

