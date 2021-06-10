using System;
using System.Collections.Generic;
using POO_ProjetoProdutos.Interfaces;

namespace POO_ProjetoProdutos.Classes
{
    public class Usuario : IUsuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Usuario> ListaUsuario = new List<Usuario>();
        public Usuario()
        {

        }

        public Usuario(int _codigo, string _nome, string _email, string _senha)
        {
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Email = _email;
            this.Senha = _senha;
            this.DataCadastro = DateTime.Now;

        }

        public string Cadastrar(Usuario usuario)
        {
            usuario.DataCadastro = DateTime.Now;
            ListaUsuario.Add(usuario);

            return $"Usuário {usuario.Nome} Cadastrado com sucesso";

        }

        public string Deletar(Usuario usuario)
        {
            Console.WriteLine("Qual é o nome do usuario que você deseja deletar?");
            string deletarusuario = Console.ReadLine();

            ListaUsuario.RemoveAll(x => x.Nome == deletarusuario);
            return $"Usuário {deletarusuario} deletado com sucesso";
        }
    }
}