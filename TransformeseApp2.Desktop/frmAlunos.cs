using TransformeseApp2.BLL;
using TransformeseApp2.DAL;
using TransformeseApp2.DTO;

namespace TransformeseApp2.Desktop
{
    public partial class frmAlunos : Form
    {
        private readonly AlunoBLL alunoBLL = new();
        private int? alunoSelecionadoId = null;
        public frmAlunos()
        {
            InitializeComponent();
        }

        private void frmAlunos_Load(object sender, EventArgs e)

        {
            if (!Database.Cursos.Any())
            {
                Database.Cursos.Add(new CursoDTO { Id = 1, Nome = "Programador de Sistemas" });
                Database.Cursos.Add(new CursoDTO { Id = 2, Nome = "Banco de Dados" });
            }

            if (!Database.Unidades.Any())
            {
                Database.Unidades.Add(new UnidadeDTO { Id = 1, Nome = "SMP - São Miguel Paulista" });
                Database.Unidades.Add(new UnidadeDTO { Id = 2, Nome = "ITQ - Itaquera" });
            }


            cboCurso.DataSource = Database.Cursos;
            cboCurso.DisplayMember = "Nome";
            cboCurso.ValueMember = "Id";


            cboUnidade.DataSource = Database.Unidades;
            cboUnidade.DisplayMember = "Nome";
            cboUnidade.ValueMember = "Id";

            cboUnidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCurso.DropDownStyle = ComboBoxStyle.DropDownList;

            AtualizarGrid();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var aluno = new AlunoDTO
                {
                    Id = Database.Alunos.Count + 1,
                    Nome = txtNome.Text,
                    CursoId = (int)cboCurso.SelectedValue,
                    UnidadeId = (int)cboUnidade.SelectedValue
                };

                alunoBLL.CadastrarAluno(aluno);
                MessageBox.Show(

                    $"Aluno {txtNome.Text} cadastrado com sucesso",
                    "Cadastro de Aluno",
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

        private void AtualizarGrid()
        {
            var lista = alunoBLL.ListarAlunos()
                                .Select(aluno => new
                                {
                                    aluno.Id,
                                    aluno.Nome,
                                    Curso = Database.Cursos.First(curso => curso.Id == aluno.CursoId).Nome,
                                    Unidade = Database.Unidades.First(unidade => unidade.Id == aluno.UnidadeId).Nome,

                                }).ToList();

            dgAlunos.DataSource = lista;
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgAlunos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um aluno para excluir.");
                return;
            }

            int Id = dgAlunos.SelectedRows[0].Cells["Id"].Value.GetHashCode();

            string Nome = dgAlunos.SelectedRows[0].Cells["Nome"].Value.ToString();

            DialogResult confirmacao = MessageBox.Show
                (
                $"Tem certeza que deseja excluir o aluno {Nome}?",
                "Confirmação de exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    alunoBLL.RemoverAluno(Id);
                    MessageBox.Show($"Aluno {Nome} excluido com sucesso.");

                    AtualizarGrid();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir aluno" + ex.Message);
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (alunoSelecionadoId != null)
            {
                btnAtualizar.Enabled = true;

                try
                {
                    var alunoAtualizado = new AlunoDTO
                    {
                        Id = alunoSelecionadoId.Value,
                        Nome = txtNome.Text,
                        CursoId = (int)cboCurso.SelectedValue,
                        UnidadeId = (int)cboUnidade.SelectedValue,
                    };
                    alunoBLL.AtualizarAluno(alunoAtualizado);
                    MessageBox.Show($"Os dados do aluno {alunoAtualizado.Nome} foram atualizados com sucesso!");
                    txtNome.Clear();
                    alunoSelecionadoId = null;
                    AtualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

        private void dgAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                DataGridViewRow row = dgAlunos.Rows[e.RowIndex];

                alunoSelecionadoId = Convert.ToInt32(row.Cells["Id"].Value);
                txtNome.Text = row.Cells["Nome"].Value.ToString();

                string nomeCurso = row.Cells["Curso"].Value.ToString();
                string nomeUnidade = row.Cells["Unidade"].Value.ToString();

                cboCurso.SelectedValue = Database.Cursos.First(curso => curso.Nome == nomeCurso);
                cboUnidade.SelectedValue = Database.Unidades.First(unidade => unidade.Nome == nomeUnidade);

                btnAtualizar.Enabled = true;
            }
        }

        private void BuscarAluno()
        {
            string termo = txtBusca.Text.Trim().ToLower();

            var filtrados = alunoBLL.ListarAlunos().
                                        Where(aluno => aluno.Nome.ToLower().Contains(termo)).
                                            Select(aluno => new
                                            {
                                                aluno.Id,
                                                aluno.Nome,
                                                Curso = Database.Cursos.First(curso => curso.Id == aluno.CursoId).Nome,
                                                Unidade = Database.Unidades.First(unidade => unidade.Id == aluno.Unidade.Id).Nome

                                            }).ToList();

            dgAlunos.DataSource = filtrados;
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            BuscarAluno();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            BuscarAluno();
        }
    }
}