
namespace Interdisciplinar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.bntConsulta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.MistyRose;
            this.btnCadastro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastro.ForeColor = System.Drawing.Color.Crimson;
            this.btnCadastro.Location = new System.Drawing.Point(119, 270);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(165, 55);
            this.btnCadastro.TabIndex = 1;
            this.btnCadastro.Text = "Cadastro Produto";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // bntConsulta
            // 
            this.bntConsulta.BackColor = System.Drawing.Color.MistyRose;
            this.bntConsulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntConsulta.ForeColor = System.Drawing.Color.Crimson;
            this.bntConsulta.Location = new System.Drawing.Point(119, 485);
            this.bntConsulta.Name = "bntConsulta";
            this.bntConsulta.Size = new System.Drawing.Size(165, 58);
            this.bntConsulta.TabIndex = 2;
            this.bntConsulta.Text = "Consulta";
            this.bntConsulta.UseVisualStyleBackColor = false;
            this.bntConsulta.Click += new System.EventHandler(this.bntConsulta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox1.BackgroundImage = global::Interdisciplinar.Properties.Resources.BoloseDocesFundo;
            this.pictureBox1.Image = global::Interdisciplinar.Properties.Resources.CasaBolosLogo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(119, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cadastro Cliente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Interdisciplinar.Properties.Resources.BoloseDocesFundo;
            this.ClientSize = new System.Drawing.Size(397, 582);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bntConsulta);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button bntConsulta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

