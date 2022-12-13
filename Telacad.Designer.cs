
namespace Interdisciplinar
{
    partial class Telacad
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
            this.bntcad = new System.Windows.Forms.Button();
            this.txtnmproduto = new System.Windows.Forms.TextBox();
            this.tipproduto = new System.Windows.Forms.TextBox();
            this.tmnhopro = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Location = new System.Drawing.Point(83, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo do Produto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Location = new System.Drawing.Point(83, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo do Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label3.Location = new System.Drawing.Point(83, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tamanho do Produto";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bntcad
            // 
            this.bntcad.BackColor = System.Drawing.Color.PeachPuff;
            this.bntcad.Location = new System.Drawing.Point(203, 445);
            this.bntcad.Name = "bntcad";
            this.bntcad.Size = new System.Drawing.Size(96, 26);
            this.bntcad.TabIndex = 3;
            this.bntcad.Text = "Cadastrar";
            this.bntcad.UseVisualStyleBackColor = false;
            this.bntcad.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnmproduto
            // 
            this.txtnmproduto.Location = new System.Drawing.Point(220, 166);
            this.txtnmproduto.Name = "txtnmproduto";
            this.txtnmproduto.Size = new System.Drawing.Size(163, 23);
            this.txtnmproduto.TabIndex = 4;
            // 
            // tipproduto
            // 
            this.tipproduto.Location = new System.Drawing.Point(220, 209);
            this.tipproduto.Name = "tipproduto";
            this.tipproduto.Size = new System.Drawing.Size(163, 23);
            this.tipproduto.TabIndex = 5;
            // 
            // tmnhopro
            // 
            this.tmnhopro.Location = new System.Drawing.Point(220, 252);
            this.tmnhopro.Name = "tmnhopro";
            this.tmnhopro.Size = new System.Drawing.Size(163, 23);
            this.tmnhopro.TabIndex = 6;
            this.tmnhopro.TextChanged += new System.EventHandler(this.tmnhopro_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Salmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(358, 99);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interdisciplinar.Properties.Resources.CasaBolosLogo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(148, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Location = new System.Drawing.Point(12, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Telacad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(494, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tmnhopro);
            this.Controls.Add(this.tipproduto);
            this.Controls.Add(this.txtnmproduto);
            this.Controls.Add(this.bntcad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Telacad";
            this.Text = "Telacad";
            this.Load += new System.EventHandler(this.Telacad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntcad;
        private System.Windows.Forms.TextBox txtnmproduto;
        private System.Windows.Forms.TextBox tipproduto;
        private System.Windows.Forms.TextBox tmnhopro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}