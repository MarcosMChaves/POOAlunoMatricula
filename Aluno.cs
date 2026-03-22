
using OOPFoundation;

namespace POOAlunoMatricula
{
    public class Aluno
    {
        private readonly Text Nome;
        private readonly Text Sobrenome;
        private readonly Matricula Matricula;

        public Aluno(Text nome, Text sobrenome, Matricula matricula)
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
            return $"{Nome.GetText()} {Sobrenome.GetText()}";
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
