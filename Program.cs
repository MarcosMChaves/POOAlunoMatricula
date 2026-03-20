using FlexAPessoa;
using POOAlunoMatricula;

try
{
    Texto nome = new Texto(texto: "Gabriela", patternValido: "\\p{L}\\s.");
    Texto sobrenome = new Texto(texto: "Xavier", patternValido: "\\p{L}\\s.");
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
