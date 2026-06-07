using System;

namespace Sistema.Models
{
    public class Medalha
    {
        // Atributos
        private int idMedalha;
        private string nomeMedalha;
        private string descricao;
        private string iconeCaminho;

        // Propriedades
        public int IdMedalha
        {
            get { return idMedalha; }
            set { idMedalha = value; }
        }

        public string NomeMedalha
        {
            get { return nomeMedalha; }
            set { nomeMedalha = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public string IconeCaminho
        {
            get { return iconeCaminho; }
            set { iconeCaminho = value; }
        }

        // Construtor
        public Medalha(
            int idMedalha,
            string nomeMedalha,
            string descricao,
            string iconeCaminho)
        {
            this.idMedalha = idMedalha;
            this.nomeMedalha = nomeMedalha;
            this.descricao = descricao;
            this.iconeCaminho = iconeCaminho;
        }

        // Método
        public void ExibirDados()
        {
            Console.WriteLine($"ID da Medalha: {idMedalha}");
            Console.WriteLine($"Nome: {nomeMedalha}");
            Console.WriteLine($"Descrição: {descricao}");
            Console.WriteLine($"Ícone: {iconeCaminho}");
        }
    }
}