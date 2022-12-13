
namespace Interdisciplinar
{
    partial class Telaconsulta
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.combox = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnpesquicliente = new System.Windows.Forms.Button();
            this.dataGridcliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Interdisciplinar.Properties.Resources.CasaBolosLogo_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(315, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 152);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(-3, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(799, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(285, 122);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.Pink;
            this.btnvoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvoltar.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnvoltar.ForeColor = System.Drawing.Color.Brown;
            this.btnvoltar.Location = new System.Drawing.Point(337, 365);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(101, 32);
            this.btnvoltar.TabIndex = 3;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // combox
            // 
            this.combox.BackColor = System.Drawing.SystemColors.Info;
            this.combox.DisplayMember = "Bolos";
            this.combox.FormattingEnabled = true;
            this.combox.Items.AddRange(new object[] {
            "Bolos"});
            this.combox.Location = new System.Drawing.Point(88, 71);
            this.combox.Name = "combox";
            this.combox.Size = new System.Drawing.Size(121, 23);
            this.combox.TabIndex = 4;
            this.combox.SelectedIndexChanged += new System.EventHandler(this.combox_SelectedIndexChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnsearch.ForeColor = System.Drawing.Color.IndianRed;
            this.btnsearch.Location = new System.Drawing.Point(88, 116);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 6;
            this.btnsearch.Text = "Procurar";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(40, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Doces:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(519, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cliente:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(572, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 9;
            // 
            // btnpesquicliente
            // 
            this.btnpesquicliente.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnpesquicliente.Location = new System.Drawing.Point(572, 116);
            this.btnpesquicliente.Name = "btnpesquicliente";
            this.btnpesquicliente.Size = new System.Drawing.Size(75, 23);
            this.btnpesquicliente.TabIndex = 10;
            this.btnpesquicliente.Text = "Pesquisar";
            this.btnpesquicliente.UseVisualStyleBackColor = false;
            this.btnpesquicliente.Click += new System.EventHandler(this.btnpesquicliente_Click);
            // 
            // dataGridcliente
            // 
            this.dataGridcliente.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridcliente.Location = new System.Drawing.Point(489, 223);
            this.dataGridcliente.Name = "dataGridcliente";
            this.dataGridcliente.RowTemplate.Height = 25;
            this.dataGridcliente.Size = new System.Drawing.Size(285, 122);
            this.dataGridcliente.TabIndex = 11;
            // 
            // Telaconsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 404);
            this.Controls.Add(this.dataGridcliente);
            this.Controls.Add(this.btnpesquicliente);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.combox);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Telaconsulta";
            this.Text = "Telacadastro";
            this.Load += new System.EventHandler(this.Telaconsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.ComboBox combox;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnpesquicliente;
        private System.Windows.Forms.DataGridView dataGridcliente;
    }
}