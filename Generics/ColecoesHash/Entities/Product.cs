using System;

namespace ColecoesHash.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        //para verificar o hashcode
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        //para verificar os objetos com o Equals
        public override bool Equals(object obj)
        {
            if(!(obj is Product))
            {
                return false;
            }

            Product other = obj as Product;

            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}
