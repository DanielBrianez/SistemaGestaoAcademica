using TransformeseApp2.BLL;
using TransformeseApp2.DAL;
using TransformeseApp2.DTO;

namespace TransformeseApp2.Desktop
{
    public partial class frmCursos : Form
    {
        private readonly CursoBLL cursoBLL = new();
        public frmCursos()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var curso = new CursoDTO
                {
                    Id = Database.Cursos.Count + 1,
                    Nome = txtNome.Text,
                    CargaHoraria = int.Parse(txtCargaHoraria.Text),
                };

                cursoBLL.CadastrarCurso(curso);
                MessageBox.Show(

                    $"Curso {txtNome.Text} cadastrado com sucesso",
                    "Cadastro de cursos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                AtualizarGrid();
                txtNome.Clear();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro: {erro.Message}");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgCursos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um curso para excluir.");
                return;
            }

            int Id = dgCursos.SelectedRows[0].Cells["Id"].Value.GetHashCode();

            string Nome = dgCursos.SelectedRows[0].Cells["Nome"].Value.ToString();

            int CargaHoraia = dgCursos.SelectedRows[0].Cells["CargaHoraria"].Value.GetHashCode();

            DialogResult confirmacao = MessageBox.Show
                (
                $"Tem certeza que deseja excluir o curso {Nome}?",
                "Confirmação de exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    cursoBLL.RemoverCurso(Id);
                    MessageBox.Show($"Curso {Nome} excluido com sucesso.");

                    AtualizarGrid();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir curso" + ex.Message);
                }
            }
        }
        private void AtualizarGrid()
        {
            var lista = cursoBLL.ListarCursos()
                                .Select(curso => new
                                {
                                    curso.Id,
                                    curso.Nome,
                                    curso.CargaHoraria

                                }).ToList();

            dgCursos.DataSource = lista;
        }

        private void BuscarCurso()
        {
            string termo = txtPesquisar.Text.Trim().ToLower();

            var filtrados = cursoBLL.ListarCursos().
                                        Where(curso => curso.Nome.ToLower().Contains(termo)).
                                            Select(curso => new
                                            {
                                                curso.Id,
                                                curso.Nome,
                                                curso.CargaHoraria

                                            }).ToList();

            dgCursos.DataSource = filtrados;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            BuscarCurso();
        }
    }
}
