using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Manha
{
    public class Produto
    {
        private int id;
        private string Descricao;
        private decimal Valor;

        public Produto(int id, string descricao, decimal valor)
        {
            this.id = id;
            this.Descricao = descricao;
            this.Valor = valor;
        }
    }
}
