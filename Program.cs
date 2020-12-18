using System;

namespace EmpresaEventos03
{
    class Program //user interface through the console application
    {
        public static string opc;
        static void Main(string[] args)
        {
            do
            {
                // console app menu to input data
                Console.Clear();
                Console.WriteLine("Bem Vindo ao Eventos 1.0");
                Console.WriteLine("=============================");
                Console.WriteLine("Selecione a opção desejada");
                Console.WriteLine("[1] Adicionar Evento");
                Console.WriteLine("[2] Pesquisar Evento por Nome");
                Console.WriteLine("[3] Pesquisar Evento por Id");
                Console.WriteLine("[4] Remover Evento por Id");
                Console.WriteLine("[5] Listar Eventos");
                Console.WriteLine("[6] Guardar Eventos");
                Console.WriteLine("[7] Encerrar Programa");
                Console.WriteLine("=============================");
                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        Console.WriteLine();
                        AdEvent();
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine();
                        PesNome();
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine();
                        PesID();
                        Console.ReadLine();
                        break;

                    case "4":
                        Console.WriteLine();
                        RemovEvent();
                        Console.ReadLine();
                        break;

                    case "5":
                        Console.WriteLine();
                        listarEvent();
                        Console.ReadLine();
                        break;

                    //case "6":
                    //    Console.WriteLine();
                    //    GuardEvent();
                    //    Console.ReadLine();
                    //    break;

                    case "7":
                        Console.WriteLine();
                        Console.WriteLine("Fim Do Programa Eventos Eventos 1.0");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Opção Invalida!!");
                        Console.ReadLine();
                        break;
                }
            } while (opc != "7") ;

        }

        private static void AdEvent() { ListaEventos.Adicionar(); }

        private static void PesNome() { ListaEventos.PesquisarNome(); }

        private static void PesID() { ListaEventos.PesquisarId(); }
      
        private static void RemovEvent() { ListaEventos.Remover(); }

        private static void listarEvent() { ListaEventos.Listar(); }

    }
}
