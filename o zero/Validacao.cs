using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o_zero
{
    class Validacao
    {
        Categoria categoria = new Categoria();
        public string ValidaString()     //validação para string campo vazio
        {
            string Resposta;
            do
            {
                Resposta = Console.ReadLine().Trim();
                if (Resposta.Equals(string.Empty))     
                {
                    Console.WriteLine("Campo vazio! Preencha o campo para continuar!");
                }
            } while (Resposta == string.Empty);
            return Resposta;
        }
        public int Validanum() //validação para numeros inteiros
        {
            int Resposta = -1;
            do
            {
                try
                {
                    Resposta = int.Parse(Console.ReadLine().Trim());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Coloque um numero válido");
                }

            } while (Resposta == -1);
            return Resposta;
        }

        public decimal Validadec()  //validação para numeros decimais
        {
            decimal Resposta = -1;
            do
            {
                try
                {
                    Resposta = Convert.ToDecimal(Console.ReadLine().Trim());
                }
                catch (Exception)
                {
                    Console.WriteLine("Coloque um numero válido");
                }

            } while (Resposta == -1);
            return Resposta;
        }
        public Categoria ProcuraId() //procura id em categoria
        {
            int idCat;
            do
            {
                if(Menu.listc.Count<=0) //verifica se a lista esta vazia
                {
                    Console.Clear();
                    Console.WriteLine("\nnenhuma categoria cadastrada! cadastre uma categoria para este item!");
                    categoria.CadastroC();  //cadastra uma categoria
                    foreach (var item in Menu.listc)    
                    {
                        return item;    //retorna unica categoria para o produto
                    }
                }
                Console.Clear();
                new MostrarListaC().Mostrarlistac();    //mostra lista de categorias
                Console.WriteLine("\nDigite o ID de uma categoria acima : ");
                idCat = Validanum();
                foreach (var item in Menu.listc)    //percorre a lista de categorias
                {
                    if (item.Id == idCat)   //verifica se o id é compativel com algum da lista
                    {
                        return item;
                    }
                    else    //caso não for ele pede para criar uma 
                    {
                        string res;
                        Console.WriteLine("categoria não existente!");
                        Console.WriteLine("deseja cadastrar uma nova categoria para este item? S/N");
                        res = ValidaString().ToLower();
                        if(res == "s")      //se a resposta anterior for sim ele entra para cadastrar uma nova categoria
                        {
                            categoria.CadastroC();  
                            break;
                        }
                    }
                }
            } 
            while (true);
        }
    }
}
