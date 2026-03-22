using POOFoundation;
using POOAlunoMatricula;

try
{
    Text nome = new Text(text: "Gabriela", validPattern: "\\p{L}\\s.");
    Text sobrenome = new Text(text: "Xavier", validPattern: "\\p{L}\\s.");
    Matricula matricula = new Matricula(numero: "H1234567",
                                    patternValido: "A-Z0-9",
                                    minimoCaracteres: 8,
                                    maximoCaracteres: 8);
    Aluno gabi = new Aluno(nome: nome, sobrenome: sobrenome, matricula: matricula);

    Console.WriteLine($"Aluna {gabi.ObterNomeCompleto()}");
    Console.WriteLine($"Aluna {gabi.ObterNomeCompletoComMatricula()}");
}
catch (ArgumentException e)
{
    Console.WriteLine($"{e.Message}");
}
