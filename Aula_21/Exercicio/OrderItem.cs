using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_21.Exercicio
{
    public class OrderItem(int quantity, double price)
    {
        public int Quantity { get; set; } = quantity;
        public double Price { get; set;} = price;

        public double SubTotal()
        {
            return Price * Quantity;
        }
    }
}