﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        public static object ContaCorrente { get; private set; }

        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(847, 489754);

            Console.WriteLine(conta.Numero);

            Console.ReadLine();

        }
    }
}
