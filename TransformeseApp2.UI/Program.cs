using TransformeseApp2.BLL;
using TransformeseApp2.DTO;

AlunoBLL alunoBLL = new AlunoBLL();
CursoBLL cursoBLL = new CursoBLL();
UnidadeBLL unidadeBLL = new UnidadeBLL();

while (true)
{
    Console.Clear();
    Console.WriteLine(" === Sistema de Cadastro de Alunos === ");
    Console.WriteLine(" 1 - Cadastrar Aluno");
    Console.WriteLine(" 2 - Listar Alunos");
    Console.WriteLine(" 3 - Cadastrar Curso");
    Console.WriteLine(" 4 - Listar Cursos");
    Console.WriteLine(" 5 - Cadastrar Unidade");
    Console.WriteLine(" 6 - Listar Unidades");
    Console.WriteLine(" 0 - Sair");
    
    Console.WriteLine(" Escolha uma opção: ");

    string opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Nome do aluno: ");
            string nomeAluno = Console.ReadLine();  
            
            Console.WriteLine("ID do curso:");
            int cursoId = int.Parse(Console.ReadLine());
            
            Console.WriteLine("ID da unidade:");
            int unidadeId = int.Parse(Console.ReadLine());

            alunoBLL.CadastrarAluno(new AlunoDTO
            {
                Nome = nomeAluno,
                CursoId = cursoId,
                UnidadeId = unidadeId,

            });

            Console.WriteLine($"Aluno {nomeAluno} cadastrado com sucesso!");

            pause();
            break;

        case "2":
            Console.Clear();
            Console.WriteLine("=== Lista de alunos ===");

            var alunos = alunoBLL.ListarAlunos();
            foreach ( var aluno in alunos)
            {
                var curso = cursoBLL.GetById(aluno.CursoId);
                var unidade = unidadeBLL.GetById(aluno.UnidadeId);

                Console.WriteLine(

                    $"""
                    /n

                    ID: {aluno.Id}
                    Nome:{aluno.Nome}
                    Curso: {curso?.Nome ?? "Não encontrado"}
                    Unidade: {unidade?.Nome ?? "Não encontrada"}

                    /n
                    """

                   );
            }

            pause();
            break;

            case "3":

            Console.WriteLine("Nome do curso: ");
            string nomeCurso = Console.ReadLine();

            Console.WriteLine("Carga horária do curso (em horas): ");
            int cargaHoraria = int.Parse(Console.ReadLine());    


            cursoBLL.CadastrarCurso(new CursoDTO
            {

                Nome = nomeCurso,
                CargaHoraria = cargaHoraria

            });

            Console.WriteLine($"Curso {nomeCurso} com carga horária de {cargaHoraria}h cadastrado com sucesso!");

            pause();
            break;

            case "4":

            Console.Clear();
            var cursos = cursoBLL.ListarCursos();
            foreach(var curso in cursos)
            {
                Console.WriteLine(
                    $"""
                    /n

                    ID: {curso.Id}
                    Nome: {curso.Nome}
                    Carga Horária: {curso.CargaHoraria}

                    /n
                    """

                   );
            }

            pause();
            break;

            case "5":

            Console.WriteLine("Nome da unidade: ");
            string nomeUnidade = Console.ReadLine();

            Console.WriteLine("Endereço da unidade: ");
            string enderecoUnidade = Console.ReadLine();


            unidadeBLL.CadastrarUnidade(new UnidadeDTO
            {

                Nome = nomeUnidade,
                Endereco = enderecoUnidade

            });

            Console.WriteLine($"Unidade {nomeUnidade} cadastrada com sucesso!");

            pause();
            break;

            case "6":

            Console.Clear();
            var unidades = unidadeBLL.ListarUnidades();
            foreach (var unidade in unidades)
            {
                Console.WriteLine(
                    $"""
                    /n

                    ID: {unidade.Id}
                    Nome: {unidade.Nome}
                    Endereço: {unidade.Endereco}

                    /n
                    """

                   );
            }

            pause();
            break;

            case "0":

            return;

        default:

            Console.WriteLine("Opção inválida");
            pause();
            break;
    }
}

static void pause()
{
    Console.WriteLine("\n Pressione qualquer tecla para continuar...");
    Console.ReadKey();
}