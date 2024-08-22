public class Livro : ItemBiblioteca
{
//definido atributo
    public string? Autor{get; set;}

//subscrevendo metodo para definir atributo ID
    public override void IDLivro(int id)
    {
        this.ID = id;
    }

//subscrevendo metodo para definir atributo Titulo
    public override void NomeLivro(string titulo)
    {
        this.Titulo = titulo;
    }

//subscrevendo metodo para definir todos os atributos de ItemBiblioteca
    public void LivroCompleto(int id, string titulo, string autor)
    {
        this.ID = id;
        this.Titulo = titulo;
        this.Autor = autor;
        DescricaoLivro();
    }

//metodo que retorna DescricaoInterna
    public string ExibirDescricaoInterna()
    {
        return DescricaoInterna;
    }
}