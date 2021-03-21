using System;
using System.Collections.Generic;

namespace dio_project_poo
{
    class Program
    {
        static List<Conta> listaContas = new List<Conta>();
        static void Main(string[] args)
        {
            string Opcao = OpcaoUsuario();
            Console.WriteLine("");
            while (Opcao.ToUpper() != "X")
            {
                switch (Opcao)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;

                    case "3":
                        Depositar();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Transferir();
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        Opcao = OpcaoUsuario();
                        Console.WriteLine("");
                        break;
                }
                Opcao = OpcaoUsuario();
                Console.WriteLine("");
            }
            Console.WriteLine("Obrigado por utilizar o serviço!");
            Console.ReadLine();
        }

        private static void ListarContas()
        {
            if (listaContas.Count == 0)
            {
                Console.WriteLine("Até o momento nenhuma conta foi cadastrada.");
                return;
            }
            Console.WriteLine("Contas cadastradas: ");
            for (int i = 0; i < listaContas.Count; i++)
            {
                Conta conta = listaContas[i];
                Console.Write("#{0} . ", i);
                Console.WriteLine(conta);
            }
        }

        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova conta");
            Console.WriteLine("Digite o nome do cliente: ");
            string entradaNome = Console.ReadLine();
            Console.WriteLine("Digite 1 para Conta Física ou 2 para Jurídica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o crédito inicial: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(
            nome: entradaNome,
            tipoConta: (TipoConta)entradaTipoConta,
            saldo: entradaSaldo,
            credito: entradaCredito);

            listaContas.Add(novaConta);

        }

        private static void Depositar()
        {
            Console.WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            if (indiceConta < 0 )
            {
                Console.WriteLine("Código de conta inválido.");
                return;
            } else if(indiceConta >= listaContas.Count){
                Console.WriteLine("Conta não cadastrada.");
                return;
            }

            Console.Write("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listaContas[indiceConta].Depositar(valorDeposito);
        }
        private static void Sacar()
        {
            Console.WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            if (indiceConta < 0 )
            {
                Console.WriteLine("Código de conta inválido.");
                return;
            } else if(indiceConta >= listaContas.Count){
                Console.WriteLine("Conta não cadastrada.");
                return;
            }

            Console.Write("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listaContas[indiceConta].Sacar(valorSaque);
        }

        private static void Transferir()
        {
            Console.WriteLine("Digite o número da conta de origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número da conta de destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());


            if(indiceContaOrigem < 0 && indiceContaDestino < 0){
                Console.WriteLine("Códigos de conta inválidos.");
                return;
            }  else if(indiceContaOrigem < 0 ){
                Console.WriteLine("Código de conta origem inválido.");
                return;
            } else if(indiceContaDestino < 0){
                Console.WriteLine("Código de conta destino inválido.");
                return;
            } 

            if (indiceContaOrigem >= listaContas.Count && indiceContaDestino >= listaContas.Count)
            {
                Console.WriteLine("Contas inexistentes.");
                return;
            } else if(indiceContaOrigem >= listaContas.Count){
                Console.WriteLine("Conta de origem não cadastrada.");
                return;
            } else if(indiceContaDestino >= listaContas.Count){
                Console.WriteLine("Conta de destino não cadastrada.");
                return;
            }
            
            Console.WriteLine("Digite o valor para transferir: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listaContas[indiceContaOrigem].Transferir(valorTransferencia, listaContas[indiceContaDestino]);
        }
        private static string OpcaoUsuario()
        {
            Console.WriteLine("");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Listar contas");
            Console.WriteLine("2 - Cadastrar conta");
            Console.WriteLine("3 - Depositar valor");
            Console.WriteLine("4 - Sacar valor");
            Console.WriteLine("5 - Transferir valor");
            Console.WriteLine("X - Sair");
            Console.WriteLine("");

            string OpcaoUsuario = Console.ReadLine();
            return OpcaoUsuario;
        }
    }
}
