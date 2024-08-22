public class Biblioteca
{
    //criando Lista
    List<ItemBiblioteca> Colecao;

    public Biblioteca()
    {
        Colecao = new List<ItemBiblioteca>();
    }

    //metodos de adicionar e remover Livro da Lista Colecao
    public void AdicionarItem(ItemBiblioteca item)
    {
        Colecao.Add(item);
    }
        public void RemoverItem(ItemBiblioteca item)
    {
        Colecao.Remove(item);
    }

//metodo para buscar Livro dentro da lista Colecao
    public ItemBiblioteca BuscarItemPorTitulo (string TituloProcurado)
    {
        return Colecao.Find(item => item.Titulo == TituloProcurado);
    }

    public ItemBiblioteca BuscarItemPorID (int IDProcurado)
    {
        return Colecao.Find(item => item.ID == IDProcurado);
    }
}