//definindo os objetos
Biblioteca B1 = new();
Livro L1 = new();
Livro L2 =new();

//definindo atributos dos objetos Livro e ItemBiblioteca
L1.LivroCompleto(1, "Pequeno Principe", "Antoine");
L2.IDLivro(2);
L2.NomeLivro("Diario de um banana");
L2.Autor = "Jeff";
L2.DescricaoLivro();

//adicionando Livro na Lista Colecao
B1.AdicionarItem(L1);
B1.AdicionarItem(L2);

//buscando Livro dentro da lista Colecao
ItemBiblioteca LivroEncontrado = B1.BuscarItemPorID(1);
Console.WriteLine($"Livro encontrado foi {LivroEncontrado.Titulo}");

//exibindo descrição interna de um livro
Console.WriteLine(L1.ExibirDescricaoInterna());

//removendo Livro da lista Colecao
B1.RemoverItem(L2);

