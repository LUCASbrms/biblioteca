public abstract class ItemBiblioteca
{
//definindo atributos
    public int ID;
    public string? Titulo;
    protected string? DescricaoInterna;

//definifo betodos abstratos
    public abstract void NomeLivro(string titulo);
    public abstract void IDLivro(int id);

//definindo metodo DecricaoLivro
    public void DescricaoLivro()
    {
        DescricaoInterna = "descrição do livro";
    }
    

    
}