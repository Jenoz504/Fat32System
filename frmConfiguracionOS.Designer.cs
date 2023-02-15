
namespace Fat32System
{
    partial class frmConfiguracionOS
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
            this.btnConfig = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLimiteCPU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtLimiteRAM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfig.BackColor = System.Drawing.Color.Gray;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnConfig.Location = new System.Drawing.Point(39, 218);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(67, 23);
            this.btnConfig.TabIndex = 27;
            this.btnConfig.Text = "Configurar";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(38, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Escriba el limite de tiempo de CPU(ms)";
            // 
            // txtLimiteCPU
            // 
            this.txtLimiteCPU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLimiteCPU.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLimiteCPU.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLimiteCPU.Location = new System.Drawing.Point(39, 135);
            this.txtLimiteCPU.Name = "txtLimiteCPU";
            this.txtLimiteCPU.Size = new System.Drawing.Size(214, 20);
            this.txtLimiteCPU.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Escriba el limite de memoria RAM (Megabytes)";
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtras.BackColor = System.Drawing.Color.Gray;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAtras.Location = new System.Drawing.Point(186, 218);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(67, 23);
            this.btnAtras.TabIndex = 24;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtLimiteRAM
            // 
            this.txtLimiteRAM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLimiteRAM.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLimiteRAM.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLimiteRAM.Location = new System.Drawing.Point(39, 60);
            this.txtLimiteRAM.Name = "txtLimiteRAM";
            this.txtLimiteRAM.Size = new System.Drawing.Size(214, 20);
            this.txtLimiteRAM.TabIndex = 22;
            // 
            // frmConfiguracionOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(301, 285);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLimiteCPU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtLimiteRAM);
            this.Name = "frmConfiguracionOS";
            this.Text = "frmConfiguracionOS";
            this.Load += new System.EventHandler(this.frmConfiguracionOS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLimiteCPU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox txtLimiteRAM;
    }
}