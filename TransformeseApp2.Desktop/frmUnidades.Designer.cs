namespace TransformeseApp2.Desktop
{
    partial class frmUnidades
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
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnCadastrar = new Button();
            btnExcluir = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnPesquisar = new Button();
            textBox3 = new TextBox();
            dgUnidades = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgUnidades).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(482, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(12, 152);
            label3.Name = "label3";
            label3.Size = new Size(215, 28);
            label3.TabIndex = 22;
            label3.Text = "Cadastro de unidades";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkGreen;
            btnCadastrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCadastrar.ForeColor = Color.Transparent;
            btnCadastrar.Location = new Point(12, 372);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 36);
            btnCadastrar.TabIndex = 23;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.Transparent;
            btnExcluir.Location = new Point(152, 372);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 36);
            btnExcluir.TabIndex = 24;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 210);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 25;
            label1.Text = "Nome da unidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 278);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 27;
            label2.Text = "Endereço da unidade";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 228);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 23);
            textBox1.TabIndex = 28;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 296);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 23);
            textBox2.TabIndex = 29;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.DodgerBlue;
            btnPesquisar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPesquisar.ForeColor = Color.Transparent;
            btnPesquisar.Location = new Point(420, 152);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 36);
            btnPesquisar.TabIndex = 30;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(254, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(160, 23);
            textBox3.TabIndex = 31;
            // 
            // dgUnidades
            // 
            dgUnidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUnidades.Location = new Point(254, 189);
            dgUnidades.Name = "dgUnidades";
            dgUnidades.Size = new Size(240, 219);
            dgUnidades.TabIndex = 32;
            // 
            // frmUnidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 450);
            Controls.Add(dgUnidades);
            Controls.Add(textBox3);
            Controls.Add(btnPesquisar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExcluir);
            Controls.Add(btnCadastrar);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Name = "frmUnidades";
            Text = "frmUnidades";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgUnidades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private Button btnCadastrar;
        private Button btnExcluir;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnPesquisar;
        private TextBox textBox3;
        private DataGridView dgUnidades;
    }
}