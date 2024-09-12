using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InfoCraft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuarMENU = false; bool res = false; //Variaveis
            do
            {
                //Menu
                Console.WriteLine("InfoCrfat");
                Console.WriteLine("O Gerador De Dados");
                Console.WriteLine("1 - CPF\n2 - RG\n3 - CNPJ\n4 - CEP\n5 - Telefone\n6 - Placa\n7 - Sair");
                Console.Write("Qual gerador deseja: ");
                string gerador = Console.ReadLine();
                //Escolha do menu
                switch (gerador)
                {
                    case "1":
                        //CPF
                        Console.Clear();
                        res = CPF();
                        if (res == true) { Console.Clear(); continuarMENU = true;}
                        break;
                    case "2":
                        //Rg
                        Console.Clear();
                        res = RG();
                        if (res == true) { Console.Clear(); continuarMENU = true; }
                        break;
                    case "3":
                        //Cnpj
                        Console.Clear();
                        res = CNPJ();
                        if (res == true) { Console.Clear(); continuarMENU = true; }
                        break;
                    case "4":
                        //Cep
                        Console.Clear();
                        res = CEP();
                        if (res == true) { Console.Clear(); continuarMENU = true; }
                        break;
                    case "5":
                        //Telefone
                        Console.Clear();
                        res = TELEFONE();
                        if (res == true) { Console.Clear(); continuarMENU = true; }
                        break;
                    case "6":
                        //Placa
                        Console.Clear();
                        res = Placa();
                        if (res == true) { Console.Clear(); continuarMENU = true; }
                        break;
                    case "7":
                        //Sair
                        Console.WriteLine("\nInfoCraft Encerrado!");
                        continuarMENU = false;
                        break;
                    default:
                        //Erro
                        Console.Clear();
                        continuarMENU = true;
                        break;
                }
            } while (continuarMENU);
            
        }

        //Metodos
        //Retonar ao menu
        static bool RetonarMenu()
        {
            gotoSair:
            bool continuarSair = true;
            do
            {
                Console.Write("G - Gerar novamente\nR - Retonar ao menu\n");
                Console.Write("Digite aqui: ");
                string saida = Console.ReadLine();
                saida = saida.ToLower();

                switch (saida)
                {
                    case "g":
                        Console.Clear();
                        return true;
                    case "r":
                        Console.Clear();
                        return false;
                    default:
                        Console.Clear();
                        goto gotoSair;
                        
                }
            } while (continuarSair);
                
            
            
        }

        //Gerador CPF
        static bool CPF()
        {
            bool continuarCPF = true;
            do
            {
                Random random = new Random();
                int digito1 = random.Next(0, 10);
                int digito2 = random.Next(0, 10);
                int digito3 = random.Next(0, 10);
                int digito4 = random.Next(0, 10);
                int digito5 = random.Next(0, 10);
                int digito6 = random.Next(0, 10);
                int digito7 = random.Next(0, 10);
                int digito8 = random.Next(0, 10);
                int digito9 = random.Next(0, 10);
                int digito10 = random.Next(0, 10);
                int digito11 = random.Next(0, 10);
                Console.WriteLine($"CPF: {digito1}{digito2}{digito3}.{digito4}{digito5}{digito6}.{digito7}{digito8}{digito9}-{digito10}{digito11}\n");

                bool desejaContinuar = RetonarMenu();
                if (desejaContinuar == true) { continuarCPF = true; }
                else { continuarCPF = false; }
            } while (continuarCPF);

            return true;
        }

        //Gerador RG
        static bool RG()
        {
            bool continuarRG = true;
            do
            {
                Random random = new Random();
                int digito1 = random.Next(0, 10);
                int digito2 = random.Next(0, 10);
                int digito3 = random.Next(0, 10);
                int digito4 = random.Next(0, 10);
                int digito5 = random.Next(0, 10);
                int digito6 = random.Next(0, 10);
                int digito7 = random.Next(0, 10);
                int digito8 = random.Next(0, 10);
                int digito9 = random.Next(0, 10);
                Console.WriteLine($"RG: {digito1}{digito2}.{digito3}{digito4}{digito5}.{digito6}{digito7}{digito8}-{digito9}\n");

                bool desejaContinuar = RetonarMenu();
                if (desejaContinuar == true) { continuarRG = true; }
                else { continuarRG = false; }
            } while (continuarRG);

            return true;
        }

        //Gerador CNPJ
        static bool CNPJ()
        {
            bool continuarCNPJ = true;
            do
            {
                Random random = new Random();
                int digito1 = random.Next(0, 10);
                int digito2 = random.Next(0, 10);
                int digito3 = random.Next(0, 10);
                int digito4 = random.Next(0, 10);
                int digito5 = random.Next(0, 10);
                int digito6 = random.Next(0, 10);
                int digito7 = random.Next(0, 10);
                int digito8 = random.Next(0, 10);
                int digito9 = random.Next(0, 10);
                int digito10 = random.Next(0,10);
                Console.WriteLine($"CNPJ: {digito1}{digito2}.{digito3}{digito4}{digito5}.{digito6}{digito7}{digito8}/0001-{digito9}{digito10}\n");

                bool desejaContinuar = RetonarMenu();
                if (desejaContinuar == true) { continuarCNPJ = true; }
                else { continuarCNPJ = false; }
            } while (continuarCNPJ);

            return true;
        }

        //Gerador CEP
        static bool CEP()
        {
            bool continuarCEP = true;
            do
            {
                Random random = new Random();
                int digito1 = random.Next(0, 10);
                int digito2 = random.Next(0, 10);
                int digito3 = random.Next(0, 10);
                int digito4 = random.Next(0, 10);
                int digito5 = random.Next(0, 10);
                int digito6 = random.Next(0, 10);
                int digito7 = random.Next(0, 10);
                int digito8 = random.Next(0, 10);
                int digito9 = random.Next(0, 10);
                int digito10 = random.Next(0, 10);
                Console.WriteLine($"CEP: {digito1}{digito2}{digito3}{digito4}{digito5}-{digito6}{digito7}{digito8}\n");

                bool desejaContinuar = RetonarMenu();
                if (desejaContinuar == true) { continuarCEP = true; }
                else { continuarCEP = false; }
            } while (continuarCEP);

            return true;
        }

        //Gerador TELEFONE
        static bool TELEFONE()
        {
            bool continuarTelefone = true;
            do
            {
                Random random = new Random();
                int digito1 = random.Next(0, 10);
                int digito2 = random.Next(0, 10);
                int digito3 = random.Next(0, 10);
                int digito4 = random.Next(0, 10);
                int digito5 = random.Next(0, 10);
                int digito6 = random.Next(0, 10);
                int digito7 = random.Next(0, 10);
                int digito8 = random.Next(0, 10);
                int digito9 = random.Next(0, 10);
                int digito10 = random.Next(0, 10);
                int digito11 = random.Next(0,10); 
                Console.WriteLine($"Telefone: {digito1}{digito2} {digito3}{digito4}{digito5}{digito6}{digito7}{digito8}{digito9}{digito10}{digito11}\n");

                bool desejaContinuar = RetonarMenu();
                if (desejaContinuar == true) { continuarTelefone = true; }
                else { continuarTelefone = false; }
            } while (continuarTelefone);

            return true;
        }

        //Gerador TELEFONE
        static bool Placa()
        {
            bool continuarPlaca = true;
            do
            {
                //Variavesis
                string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string numeros = "0123456789";
                //Inico
                Random random = new Random();
                int modeloPlaca = random.Next(0, 2);
                StringBuilder letrasPlaca = new StringBuilder();
                StringBuilder numerosPlacas = new StringBuilder();
                StringBuilder umaLetra = new StringBuilder();
                StringBuilder umNumero = new StringBuilder();
                //Gerar as 3 letras
                for (int i = 0; i < 3; i++)
                {
                    int modeloSorteado = random.Next(0, caracteres.Length - 1);
                    letrasPlaca.Append(caracteres[modeloSorteado]);
                }
                Console.Write($"Placa: {letrasPlaca.ToString()}");
                //Modelo da placa antiga ou nova
                //Antiga
                if (modeloPlaca == 0)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int numeroSorteado = random.Next(0, numeros.Length - 1);
                        numerosPlacas.Append(numeros[numeroSorteado]);
                    }
                    Console.Write(numerosPlacas.ToString());
                }
                //Nova
                else
                {
                    //Numero
                    for (int i = 0; i < 1; i++)
                    {
                        int numeroSorteado = random.Next(0, numeros.Length - 1);
                        umNumero.Append(numeros[numeroSorteado]);
                    }
                    //Letra
                    for (int i = 0; i < 1; i++)
                    {
                        int letraSorteado = random.Next(0, caracteres.Length - 1);
                        umaLetra.Append(caracteres[letraSorteado]);
                    }
                    //Numeros
                    for (int i = 0; i < 2; i++)
                    {
                        int numeroSorteado = random.Next(0, numeros.Length - 1);
                        numerosPlacas.Append(numeros[numeroSorteado]);
                    }
                    Console.Write(umNumero.ToString() + umaLetra.ToString() +numerosPlacas.ToString());
                }
                Console.WriteLine("\n");
               
                bool desejaContinuar = RetonarMenu();
                if (desejaContinuar == true) { continuarPlaca = true; }
                else { continuarPlaca = false; }
            } while (continuarPlaca);

            return true;
        }


    }
}
