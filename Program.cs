using System;

namespace licaodehoje
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();
            produto1.Codigo = 1;
            produto1.Nome = "Coca-cola";
            produto1.Descricao = "Refrigerente";
            produto1.Estoque = 30;

            Console.WriteLine($"Produto 1 Código {produto1.Codigo}, nome {produto1.Nome}, Descrição {produto1.Descricao} e estoque {produto1.Estoque}");

            Produto produto2 = new Produto(10);
            produto2.Nome = "Pepsi";
            Console.WriteLine($"Codigo inserido {produto2.Codigo}, nome{produto2.Nome}");

            Produto produto3 = new Produto(1, "Traquinas", "Bolacha de chocolate", 1000);
            Console.WriteLine($"Produto 3 Código {produto3.Codigo}, nome {produto3.Nome}, Descrição {produto3.Descricao} e estoque {produto3.Estoque}");
        }
    }
}
