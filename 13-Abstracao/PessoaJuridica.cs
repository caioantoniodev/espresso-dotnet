﻿using System;

namespace _13_Abstracao
{
    class PessoaJuridica : Padrao
    {
        public override void TaxaEmprestimo(double valor)
        {
            Console.WriteLine("Taxa de empréstimo para Pessoa Jurídica R$ " + (valor * 0.2));
        }
    }
}
