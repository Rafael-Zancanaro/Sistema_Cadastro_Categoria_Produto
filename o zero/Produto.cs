using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o_zero
{
    class Produto : Models
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public Categoria Categoria { get; set; }
        
        public void CadastroP()
        {
            
            
            string resp;
            do
            {
                Validacao valida = new Validacao(); //estanciamento para a validação
                Produto produto = new Produto();    //estanciamento de produto
                produto.Categoria = valida.ProcuraId();     //procura um Id na lista de categoria ou cria um automatico
                produto.Id=Menu.listp.Count +1; //contador de Id automatico
                Console.Clear();
                Console.WriteLine("\n------------ Cadastramento de Produtos ------------");
                Console.WriteLine("Digite o nome do produto: ");
                produto.Nome = valida.ValidaString();   //adiciona um nome ao produto
                Console.WriteLine("Digite o valor do produto: ");
                produto.Valor = valida.Validadec();     //adiciona um valor ao produto
                Menu.listp.Add(produto);        //adiciona os dados na lista de produtos
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Produto cadastrado com sucesso!");
                Console.ResetColor();
                Console.WriteLine("\n Deseja cadastrar mais algum item ? ");
                resp = valida.ValidaString().ToLower();
                Console.Clear();
            }
            while (resp == "s");
        }
        public override string ToString()
        {
            return $"\nID: {this.Id}\nNome: {this.Nome}\nValor: {this.Valor}\nCategoria: {this.Categoria.Nome}";    //retorna os dados em string 
        }
    }
}
