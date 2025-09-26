namespace TransformeseApp2.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pbAlunos_Click(object sender, EventArgs e)
        {
            frmAlunos telaAlunos = new frmAlunos();
            telaAlunos.ShowDialog();
        }

        private void pbCursos_Click(object sender, EventArgs e)
        {
            frmCursos telaCursos = new frmCursos();
            telaCursos.ShowDialog();
        }

        private void pbUnidades_Click_1(object sender, EventArgs e)
        {
            frmUnidades telaUnidades = new frmUnidades();
            telaUnidades.ShowDialog();
        }
    }
}
