using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaEventos03
{
    public class ListaEventos
    {

        static private List<Evento> listaEv = new List<Evento>();
        static private int contador = 0;

        public static void Adicionar()
        {
            
            Evento novoEvento = new Evento();
            novoEvento.AdDadosEvent();
            novoEvento.id = ++contador;
            listaEv.Add(novoEvento);
        }

        public static void PesquisarNome()
        {
            Console.Clear();
            Console.WriteLine("========================");
            Console.WriteLine("Pesquisar Evento por Nome");
            Console.Write("Nome do Evento: ");
            string peno = Console.ReadLine();
            for (int i = 0; i < listaEv.Count; i++)
            {
                if (listaEv[i].nome.Contains(peno))
                {
                    listaEv[i].ShowDadosEvent();
                }
            }
        }

        public static void PesquisarId()
        {
            Console.Clear();
            Console.WriteLine("========================");
            Console.WriteLine("ID do Evento: ");
            int Idev = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < listaEv.Count; i++)
            {
                if (Idev == listaEv[i].id)
                {
                    listaEv[i].ShowDadosEvent(); 
                }
            }

        }

        public static void Remover()
        {
            Console.Clear();
            Console.WriteLine("========================");
            Console.WriteLine("ID do Evento a Remover: ");
            int idev = int.Parse(Console.ReadLine());
            for (int i = 0; i < listaEv.Count; i++)
            {
                if (listaEv[i].id == idev)
                {
                    listaEv.Remove(listaEv[i]);
                    return;
                }
            }
        }

        public static void Listar()
        {
            Console.Clear();
            Console.WriteLine("========================");
            Console.WriteLine("Lista de Eventos: ");
            for (int i = 0; i < listaEv.Count; i++)
            {
                listaEv[i].ShowDadosEvent();
            }
        }
    }
}
