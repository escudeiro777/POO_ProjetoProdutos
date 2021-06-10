using POO_ProjetoProdutos.Classes;

namespace POO_ProjetoProdutos.Interfaces
{
    public interface IUsuario
    {
        string Cadastrar(Usuario usuario);
        string Deletar(Usuario usuario);
    }
}