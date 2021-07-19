using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o_zero
{
    class Opcoes
    {
        MostrarListaP mostrarp = new MostrarListaP();   //estanciamento para mostrar produto
        MostrarListaC mostrarc = new MostrarListaC();   //estanciamento para mostrar categoria
        Menu menu = new Menu(); //estanciamento de menu
        Produto cadastrop = new Produto();  //estanciamento para cadastro
        Categoria categoriac = new Categoria(); //estanciamento para categoria
        Validacao valida = new Validacao();     //estanciamento para validações
        public void Opcao()
        {
            int escolha = valida.Validanum();
            switch (escolha)
            {
                case 0:
                    break;
                case 1:
                    cadastrop.CadastroP(); //cadastra produto
                    menu.MontaMenu();      //remonta o menu
                    break;
                case 2:
                    string resp;
                    do
                    {
                        Console.Clear();
                        categoriac.CadastroC(); //cadastra categoria
                        Console.WriteLine("\nDeseja cadastrar mais algum item ? ");
                        resp = valida.ValidaString().ToLower();
                    }
                    while (resp == "s"); //caso queira cadastrar mais de uma categoria
                    Console.Clear();
                    menu.MontaMenu();   //remonta  o menu
                    break;
                case 3:
                    mostrarp.Mostrarlistap();       //mostra lista de produtos
                    Console.WriteLine("\nPress enter para voltar ao menu anterior");
                    Console.ReadLine();
                    Console.Clear();
                    menu.MontaMenu();   //remonta o menu
                    break;
                case 4:
                    mostrarc.Mostrarlistac();   //mostra lista de categorias
                    Console.WriteLine("Press enter para voltar ao menu anterior");
                    Console.ReadLine();
                    Console.Clear();
                    menu.MontaMenu();   //remonta o menu
                    break;
                default:
                    break;
            }
        }
    }
}
