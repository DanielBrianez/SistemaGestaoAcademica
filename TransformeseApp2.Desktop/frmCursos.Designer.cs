namespace TransformeseApp2.Desktop
{
    partial class frmCursos
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
            label1 = new Label();
            label2 = new Label();
            dgCursos = new DataGridView();
            btnExcluir = new Button();
            btnCadastrar = new Button();
            txtCargaHoraria = new TextBox();
            txtNome = new TextBox();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgCursos).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(495, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 198);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 10;
            label1.Text = "Nome do curso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 242);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 11;
            label2.Text = "Carga horária em horas:";
            // 
            // dgCursos
            // 
            dgCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCursos.Location = new Point(246, 166);
            dgCursos.Name = "dgCursos";
            dgCursos.Size = new Size(261, 177);
            dgCursos.TabIndex = 14;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.Transparent;
            btnExcluir.Location = new Point(115, 309);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(92, 38);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkGreen;
            btnCadastrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCadastrar.ForeColor = Color.Transparent;
            btnCadastrar.Location = new Point(12, 309);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(91, 38);
            btnCadastrar.TabIndex = 16;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtCargaHoraria
            // 
            txtCargaHoraria.Location = new Point(12, 260);
            txtCargaHoraria.Name = "txtCargaHoraria";
            txtCargaHoraria.Size = new Size(195, 23);
            txtCargaHoraria.TabIndex = 17;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 216);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(195, 23);
            txtNome.TabIndex = 18;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(246, 137);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(152, 23);
            txtPesquisar.TabIndex = 19;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.DodgerBlue;
            btnPesquisar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPesquisar.ForeColor = Color.Transparent;
            btnPesquisar.Location = new Point(404, 129);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(103, 34);
            btnPesquisar.TabIndex = 20;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(190, 28);
            label3.TabIndex = 21;
            label3.Text = "Cadastro de cursos";
            // 
            // frmCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 359);
            Controls.Add(label3);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(txtNome);
            Controls.Add(txtCargaHoraria);
            Controls.Add(btnCadastrar);
            Controls.Add(btnExcluir);
            Controls.Add(dgCursos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmCursos";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgCursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private DataGridView dgCursos;
        private Button btnExcluir;
        private Button btnCadastrar;
        private TextBox txtCargaHoraria;
        private TextBox txtNome;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private Label label3;
    }
}