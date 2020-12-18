using System;
namespace EmpresaEventos03
{
    // Class models
    public class Evento
    {
        public int id;
        public string nome;
        public DateTime dataRea;
        public string local;
        public decimal precoIngr;
        public string observ;

        //methods for adding data 
        public void AdDadosEvent()
        {
            Console.Clear();
            Console.WriteLine("Dados do Evento");
            Console.Write("Nome do Evento: ");
            nome = Convert.ToString(Console.ReadLine());
            Console.Write("Data do Evento: ");
            dataRea = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Local do Evento: ");
            local = Convert.ToString(Console.ReadLine());
            Console.Write("Preço do Ingresso: ");
            precoIngr = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Observações: ");
            observ = Convert.ToString(Console.ReadLine());
        }
        
        //methods for displaying data
        public void ShowDadosEvent()
        {
            
            Console.WriteLine("===============================");
            Console.WriteLine("ID do Evento: " + id);
            Console.WriteLine("Evento: " + nome);
            Console.WriteLine("Data do Evento: " + dataRea);
            Console.WriteLine("Local do Evento: " + local);
            Console.WriteLine("Ingresso: " + precoIngr);
            Console.WriteLine("Observações: " + observ);
            Console.WriteLine("===============================");
        }
     
        //methods for updating data
        public void AtualizarEventDados(string novoNome, DateTime novoDataRea, string novoLocal, decimal novoPrecoIngr, string novoObserv)
        {
            nome = novoNome;
            dataRea = novoDataRea;
            local = novoLocal;
            precoIngr = novoPrecoIngr;
            observ = novoObserv;
        }       
    }
}
