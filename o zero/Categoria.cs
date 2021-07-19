using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o_zero
{
    class Categoria : Models
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public void CadastroC()
        {
            Validacao validac = new Validacao();      //estanciamento
            Categoria categoria = new Categoria();    //estanciamento
            categoria.Id= Menu.listc.Count +1;        //adiciona id automatico
            Console.WriteLine("\n------------ Cadastramento de Categorias ------------");           
            Console.WriteLine("Digite o nome da categoria:");
            categoria.Nome = validac.ValidaString();   //nome da categoria
            Console.WriteLine("Digite a descrição da categoria:");
            categoria.Descricao = validac.ValidaString();  //descrição da categoria
            Menu.listc.Add(categoria);   //adiciona os dados na lista
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Categoria salva com sucesso!");
            Console.ResetColor();
        }
    }
}
