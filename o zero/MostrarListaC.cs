using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o_zero
{
    class MostrarListaC
    {
        public void Mostrarlistac()
        {
            Console.Clear();
            if(Menu.listc.Count<=0) //se a lista estiver vazia
            {
                Console.WriteLine("Nunhuma categoria cadastrada!");
            }
            else
            {
                Console.WriteLine("-------------Lista de categorias cadastradas-------------");
                foreach (var item in Menu.listc)  //percorre cada item na lista
                {
                    Console.WriteLine("---------------------------------------------------\n");
                    Console.WriteLine($"Id: {item.Id}\nNome: {item.Nome}\nDescrição: {item.Descricao}"); //mostra items percorridos na lista
                }
            }
        }
    }
}
