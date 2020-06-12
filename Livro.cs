using System;

class Livro
{
    public string Nome { get; set; }
    public int Codigo { get; set; }
    public string Descrição { get; set; }
    public string Autor { get; set; }

    public Livro()
    {

    }


    public Livro(string _nome)
    {
        this.Nome = _nome;
    }    

    public Livro(string _nome , int _codigo , string _descricao , string _autor)
    {
        this.Nome = _nome;
        this.Autor= _autor;
        this.Codigo= _codigo;
        this.Descrição= _descricao;
    }
}