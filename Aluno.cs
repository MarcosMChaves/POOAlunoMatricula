
using FlexAPessoa;

namespace POOAlunoMatricula
{
    public class Aluno
    {
        private readonly Texto Nome;
        private readonly Texto Sobrenome;
        private readonly Matricula Matricula;

        public Aluno(Texto nome, Texto sobrenome, Matricula matricula)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Sobrenome = sobrenome ?? throw new ArgumentNullException(nameof(sobrenome));
            Matricula = matricula ?? throw new ArgumentNullException(nameof(matricula));
        }

        public string ObterNomeCompleto()
        {
            return FormatarNomeCompleto();
        }
        private string FormatarNomeCompleto()
        {
            return $"{Nome.GetTexto()} {Sobrenome.GetTexto()}";
        }
        public string ObterNomeCompletoComMatricula()
        {
            return FormatarNomeCompletoComMatricula();
        }
        private string FormatarNomeCompletoComMatricula()
        {
            return $"{FormatarNomeCompleto()} ({Matricula.ObterMatricula()})";
        }
    }
}
