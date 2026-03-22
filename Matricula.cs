
using POOFoundation;
using System.Text.RegularExpressions;

namespace POOAlunoMatricula
{
    public class Matricula: ISanitization, ITextValidation
    {
        private readonly string Numero;
        private readonly string PatternValido;
        private readonly int MinimoCaracteres;
        private readonly int MaximoCaracteres;

        public Matricula(string numero, 
                            string patternValido, 
                            int minimoCaracteres = 5, 
                            int maximoCaracteres = 7)
        {
            if(minimoCaracteres < 5 ||
                maximoCaracteres > 10 ||
                minimoCaracteres > maximoCaracteres)
            {
                throw new ArgumentException($"Argumentos 'minimoCaracteres'='{minimoCaracteres}' E/OU 'maximoCaracteres'='{maximoCaracteres}' inválidos!");
            }

            MinimoCaracteres = minimoCaracteres;
            MaximoCaracteres = maximoCaracteres;
            PatternValido = patternValido.Trim();

            string numeroSanitizado = Sanitize(textoParaSanitizar: numero);
            if (!TextIsValid(textoParaValidar: numeroSanitizado))
            {
                throw new ArgumentException($"Argumento 'numero'='{numero}' inválido!");
            }

            Numero = numeroSanitizado.ToUpper();
        }
        public string Sanitize(string textoParaSanitizar)
        {
            string textoSanitizado = System.String.Empty;
            try
            {
                textoSanitizado = Regex.Replace(textoParaSanitizar, @$"[^{PatternValido}]", string.Empty).Trim();
            }
            catch (ArgumentException)
            {
                throw new ArgumentException($"Pattern 'pattern'='{PatternValido}' inválido!");
            }

            return textoSanitizado;
        }

        public bool TextIsValid(string textoParaValidar)
        {
            if (String.IsNullOrEmpty(textoParaValidar) ||
                String.IsNullOrWhiteSpace(textoParaValidar) ||
                textoParaValidar.Length < MinimoCaracteres ||
                textoParaValidar.Length > MaximoCaracteres ||
                !UltimoDigitoEhNumerico(textoParaValidar))
            {
                return false;
            }

            return true;
        }

        private bool UltimoDigitoEhNumerico(string textoParaValidar)
        {
            string ultimoDigito = textoParaValidar.Substring(textoParaValidar.Length - 1);
         
            return ultimoDigito.All(char.IsDigit);
        }

        private string FormatarMatricula()
        {
            // Formato GERAL; último dígito é DV e separado por -
            return $"{Numero.Substring(0, Numero.Length-2)}-{Numero.Substring(Numero.Length - 1)}";
        }
        public string ObterMatricula()
        {
            return FormatarMatricula();
        }
    }
}
