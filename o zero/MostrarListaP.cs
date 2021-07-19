using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o_zero
{
    

    class MostrarListaP
    {
        public void Mostrarlistap()
        {
            Console.Clear();
            if (Menu.listp.Count<=0)  //se a lista estiver vazia
            {
                Console.WriteLine("Lista de produtos vazia!");
            }
            else
            {
                Console.WriteLine("-------------Lista de produtos cadastrados-------------");
                foreach (var item in Menu.listp)  //percorre items na lista
                {
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine(item);  //mostra os items percorridos na lista
                }
            }
        }
    }
}
