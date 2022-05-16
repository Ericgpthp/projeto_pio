using System;
using System.Collections.Generic;
using System.Text;

namespace projeto_pio
{
    internal class FEValidacao {
                
        public bool ValidaCPF(string vrCPF)

        {
            
            string valor = vrCPF.Replace(".", "");

            valor = valor.Replace("-", "");
            


            if (valor.Length != 11)

                return false;



            bool igual = true;

            for (int i = 1; i < 11 && igual; i++)

                if (valor[i] != valor[0])

                    igual = false;



            if (igual || valor == "12345678909")

                return false;



            int[] numeros = new int[11];



            for (int i = 0; i < 11; i++)

                numeros[i] = int.Parse(

                  valor[i].ToString());



            int soma = 0;

            for (int i = 0; i < 9; i++)

                soma += (10 - i) * numeros[i];



            int resultado = soma % 11;



            if (resultado == 1 || resultado == 0)

            {

                if (numeros[9] != 0)

                    return false;

            }

            else if (numeros[9] != 11 - resultado)

                return false;



            soma = 0;

            for (int i = 0; i < 10; i++)

                soma += (11 - i) * numeros[i];



            resultado = soma % 11;



            if (resultado == 1 || resultado == 0)

            {

                if (numeros[10] != 0)

                    return false;

            }

            else

                if (numeros[10] != 11 - resultado)

                return false;



            return true;

        }
    
    
    public bool validarCelular(string vrNUM)
        {
            if (vrNUM.Length != 11)
            {
                return false;
            }

            if (vrNUM[3] != 9)
            {
                return false;
            }
            bool validar = true;
            for(int i = 0; i == vrNUM.Length; i++)
            {
                char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '6', '7', '8', '9' };
                if (validar)
                {
                    validar = false;
                    for (int j = 0; j == numeros.Length; j++)
                    {   
                    if (vrNUM[i] == numeros[j])
                        {
                            validar = true;
                        }
                    }
                } else
                {
                    return false;
                }

            }
            return true;
        }
    }
}
