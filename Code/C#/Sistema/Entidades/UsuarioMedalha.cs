using System;

namespace Sistema.Models
{
    public class UsuarioMedalha
    {
        // Atributos
        private int idConquista;
        private Aluno aluno;
        private Medalha medalha;
        private DateTime dataGanho;

        // Propriedades
        public int IdConquista
        {
            get { return idConquista; }
            set { idConquista = value; }
        }

        public Aluno Aluno
        {
            get { return aluno; }
            set { aluno = value; }
        }

        public Medalha Medalha
        {
            get { return medalha; }
            set { medalha = value; }
        }

        public DateTime DataGanho
        {
            get { return dataGanho; }
            set { dataGanho = value; }
        }

        // Construtor
        public UsuarioMedalha(
            int idConquista,
            Aluno aluno,
            Medalha medalha,
            DateTime dataGanho)
        {
            this.idConquista = idConquista;
            this.aluno = aluno;
            this.medalha = medalha;
            this.dataGanho = dataGanho;
        }

        // Método
        public void ExibirDados()
        {
            Console.WriteLine($"ID da Conquista: {idConquista}");
            Console.WriteLine($"Aluno: {aluno.NomeCompleto}");
            Console.WriteLine($"Medalha: {medalha.NomeMedalha}");
            Console.WriteLine($"Data de Ganho: {dataGanho:dd/MM/yyyy}");
        }
    }
}