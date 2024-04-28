using System.Globalization;

namespace Course {
    class Produto {
        //Ordem para a implementação
        //1. Atributo privativo
        private string _nome;

        //2.Propriedades autoimplementadas
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        //3. Construtores - ele obriga a classe principal a pedir os dados para iniciar essa classe
        //sobrecarga
        public Produto() {
        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //método Set
        public void SetNome(string nome) {
            if(nome != null && nome.Length > 1) {
                _nome = nome;
            }
        }

        //4. property - propriedades customizadas
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        //5. Outros métodos da uma classe
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}