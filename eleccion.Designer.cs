namespace Fat32System
{
    partial class eleccion
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
            this.Exit = new System.Windows.Forms.Button();
            this.Folder = new System.Windows.Forms.Button();
            this.file = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(94, 32);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "SALIR";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // Folder
            // 
            this.Folder.Location = new System.Drawing.Point(302, 303);
            this.Folder.Name = "Folder";
            this.Folder.Size = new System.Drawing.Size(153, 57);
            this.Folder.TabIndex = 8;
            this.Folder.Text = "CARPETA";
            this.Folder.UseVisualStyleBackColor = true;
            this.Folder.Click += new System.EventHandler(this.Folder_Click_1);
            // 
            // file
            // 
            this.file.Location = new System.Drawing.Point(87, 303);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(153, 57);
            this.file.TabIndex = 7;
            this.file.Text = "ARCHIVO";
            this.file.UseVisualStyleBackColor = true;
            this.file.Click += new System.EventHandler(this.file_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "QUE DESEA CREAR? ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(189, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 131);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // eleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Folder);
            this.Controls.Add(this.file);
            this.Controls.Add(this.label2);
            this.Name = "eleccion";
            this.Text = "eleccion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Folder;
        private System.Windows.Forms.Button file;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}