using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaEventos03
{
    public class ListaEventos
    { 
        static private List<Evento> listaEv = new List<Evento>();// creating lists
        static private int contador = 0;
        
        
        // controlling methods to add
        public static void Adicionar()
        {    
            Evento novoEvento = new Evento();
            novoEvento.AdDadosEvent();
            novoEvento.id = ++contador;
            listaEv.Add(novoEvento);
        }
        
        // controlling methods to research by name
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
        
        // controlling methods to research by ID
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
        
        // controlling methods to remove
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
        
        // controlling methods to list
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
