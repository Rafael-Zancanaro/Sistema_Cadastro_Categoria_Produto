using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o_zero
{
    class Menu
    {
        
        public static List<Categoria> listc = new List<Categoria>(); //lista de categorias
        public static List<Produto> listp = new List<Produto>();     //lista de produtos
        public void Cabecalho()
        {
            Console.WriteLine("------------------------- apenas aprendendo em casa -------------------------");
        }
        public void Rodape()
        {
            Console.WriteLine(" 1 - Cadastro de Produto.\n 2 - Cadastro de Categoria.\n 3 - Mostrar Produtos Cadastrados.\n 4 - Mostrar Categorias Cadastradas." +
                "\n 0 - Sair.");
            Console.WriteLine(" Escolha uma das opções acima: ");
        }
        public void MontaMenu()
        {
            Opcoes op = new Opcoes();
            Cabecalho();
            Rodape();
            op.Opcao();   //chama lista de opções
        }
    }
}
 