
namespace Interdisciplinar
{
    partial class telacadclient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtnm = new System.Windows.Forms.TextBox();
            this.txtcont = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txtpedido = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgtcad = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgtcad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(12, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pedido";
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(104, 63);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(162, 23);
            this.txtcod.TabIndex = 5;
            // 
            // txtnm
            // 
            this.txtnm.Location = new System.Drawing.Point(104, 106);
            this.txtnm.Name = "txtnm";
            this.txtnm.Size = new System.Drawing.Size(162, 23);
            this.txtnm.TabIndex = 6;
            // 
            // txtcont
            // 
            this.txtcont.Location = new System.Drawing.Point(104, 153);
            this.txtcont.Name = "txtcont";
            this.txtcont.Size = new System.Drawing.Size(162, 23);
            this.txtcont.TabIndex = 7;
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(104, 200);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(162, 23);
            this.txtendereco.TabIndex = 8;
            // 
            // txtpedido
            // 
            this.txtpedido.Location = new System.Drawing.Point(104, 247);
            this.txtpedido.Name = "txtpedido";
            this.txtpedido.Size = new System.Drawing.Size(162, 23);
            this.txtpedido.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.NavajoWhite;
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(71, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Moccasin;
            this.button2.Location = new System.Drawing.Point(25, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgtcad
            // 
            this.dgtcad.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgtcad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtcad.GridColor = System.Drawing.Color.Bisque;
            this.dgtcad.Location = new System.Drawing.Point(314, 63);
            this.dgtcad.Name = "dgtcad";
            this.dgtcad.RowTemplate.Height = 25;
            this.dgtcad.Size = new System.Drawing.Size(367, 207);
            this.dgtcad.TabIndex = 12;
            // 
            // telacadclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(719, 362);
            this.Controls.Add(this.dgtcad);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtpedido);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.txtcont);
            this.Controls.Add(this.txtnm);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "telacadclient";
            this.Text = "telacadclient";
            ((System.ComponentModel.ISupportInitialize)(this.dgtcad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtnm;
        private System.Windows.Forms.TextBox txtcont;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txtpedido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgtcad;
    }
}