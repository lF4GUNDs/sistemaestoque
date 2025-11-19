using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static controleEstoque.CadastroFuncionario;

namespace controleEstoque.Service
{
    public  class ValidaCpfCnpj
    {

        public enum TipoDocumento
        {
            CPF,
            CNPJ
        }

        public bool ValidarDocumento(string documento, TipoDocumento tipo)
        {


            if (string.IsNullOrWhiteSpace(documento))
                return false;

            
            documento = new string(documento.Where(char.IsDigit).ToArray());

            switch (tipo)
            {
                case TipoDocumento.CPF:
                    if (documento.Length != 11)
                        return false;

                    bool todosDigitosIguais = documento.Distinct().Count() == 1;
                    if (todosDigitosIguais)
                        return false;


                    int[] multiplicadoresPrimeiroDigitoCPF = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                    int[] multiplicadoresSegundoDigitoCPF = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                    string cpfSemDigitosVerificadores = documento.Substring(0, 9);

                    int soma = 0;
                    for (int i = 0; i < 9; i++)
                    {
                        soma += int.Parse(cpfSemDigitosVerificadores[i].ToString()) * multiplicadoresPrimeiroDigitoCPF[i];
                    }

                    int resto = soma % 11;
                    int primeiroDigitoVerificador = resto < 2 ? 0 : 11 - resto;

                    cpfSemDigitosVerificadores += primeiroDigitoVerificador;

                    soma = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        soma += int.Parse(cpfSemDigitosVerificadores[i].ToString()) * multiplicadoresSegundoDigitoCPF[i];
                    }

                    resto = soma % 11;
                    int segundoDigitoVerificador = resto < 2 ? 0 : 11 - resto;

                    cpfSemDigitosVerificadores += segundoDigitoVerificador;

                    return documento.EndsWith(primeiroDigitoVerificador.ToString() + segundoDigitoVerificador.ToString());

                case TipoDocumento.CNPJ:
                    if (documento.Length != 14)
                        return false;

                 
                    int[] multiplicadoresPrimeiroDigitoCNPJ = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                    int[] multiplicadoresSegundoDigitoCNPJ = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

                    string cnpjSemDigitosVerificadores = documento.Substring(0, 12);

                    soma = 0;
                    for (int i = 0; i < 12; i++)
                    {
                        soma += int.Parse(cnpjSemDigitosVerificadores[i].ToString()) * multiplicadoresPrimeiroDigitoCNPJ[i];
                    }

                    resto = soma % 11;
                    int primeiroDigitoCNPJ = resto < 2 ? 0 : 11 - resto;

                    cnpjSemDigitosVerificadores += primeiroDigitoCNPJ;

                    soma = 0;
                    for (int i = 0; i < 13; i++)
                    {
                        soma += int.Parse(cnpjSemDigitosVerificadores[i].ToString()) * multiplicadoresSegundoDigitoCNPJ[i];
                    }

                    resto = soma % 11;
                    int segundoDigitoCNPJ = resto < 2 ? 0 : 11 - resto;

                    cnpjSemDigitosVerificadores += segundoDigitoCNPJ;

                    return documento.EndsWith(primeiroDigitoCNPJ.ToString() + segundoDigitoCNPJ.ToString());

                default:
                    return false;
            }
        }

    }
}
