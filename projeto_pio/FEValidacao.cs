using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace projeto_pio
{
    internal class FEValidacao
    {    
        //FUNÇÃO PARA VALIDAR CPF
        public bool ValidaCPF(string vrCPF)

        {

            string valor = vrCPF.Replace(".", "");

            valor = valor.Replace("-", "");



            if (valor.Length != 11)
            {
                return false;
            }

            bool validar = true;
            for (int i = 0; i == valor.Length; i++)
            {
                char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '6', '7', '8', '9' };
                if (validar)
                {
                    validar = false;
                    for (int j = 0; j < numeros.Length; j++)
                    {
                        if (valor[i] == numeros[j])
                        {
                            validar = true;
                        }
                    }
                }
                else
                {
                    return false;
                }

            }

            return true;


        }

        //FUNÇÃO PARA VALIDAR NUMERO DE CELULAR
        public bool validarCelular(string vrNUM)
        {
            if (vrNUM.Length != 11)
            {
                return false;
            }

            if (vrNUM[2] != '9')
            {
                return false;
            }
            bool validar = true;
            for (int i = 0; i == vrNUM.Length; i++)
            {
                char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '6', '7', '8', '9' };
                if (validar)
                {
                    validar = false;
                    for (int j = 0; j < numeros.Length; j++)
                    {
                        if (vrNUM[i] == numeros[j])
                        {
                            validar = true;
                        }
                    }
                }
                else
                {
                    return false;
                }

            }
            return true;
        }              
        
        //FUNÇÃO PARA VALIDAR ENDERECO DE EMAIL
        public bool validarEmail(string email)
        {
            if (email == null)
            {
                return false;
            }
            if (new EmailAddressAttribute().IsValid(email))
            {
                return true;
            }
            else
            {

                return false;
            }
        }



    }
}



