using System;
using System.Collections.Generic;

namespace Sistema.Models
{
    public class Aula
    {
        // Atributos
        private int idAula;
        private string tituloAula;
        private string conteudoTexto;
        private int ordem;

        private Curso curso;
        private List<Avaliacao> avaliacoes;
        private List<Progresso> progressos;

        // Propriedades
        public int IdAula
        {
            get { return idAula; }
            set { idAula = value; }
        }

        public string TituloAula
        {
            get { return tituloAula; }
            set { tituloAula = value; }
        }

        public string ConteudoTexto
        {
            get { return conteudoTexto; }
            set { conteudoTexto = value; }
        }

        public int Ordem
        {
            get { return ordem; }
            set { ordem = value; }
        }

        public Curso Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        public List<Avaliacao> Avaliacoes
        {
            get { return avaliacoes; }
            set { avaliacoes = value; }
        }

        public List<Progresso> Progressos
        {
            get { return progressos; }
            set { progressos = value; }
        }

        // Construtor
        public Aula(
            int idAula,
            string tituloAula,
            string conteudoTexto,
            int ordem,
            Curso curso)
        {
            this.idAula = idAula;
            this.tituloAula = tituloAula;
            this.conteudoTexto = conteudoTexto;
            this.ordem = ordem;
            this.curso = curso;

            avaliacoes = new List<Avaliacao>();
            progressos = new List<Progresso>();
        }

        public void AdicionarAvaliacao(Avaliacao avaliacao)
        {
            avaliacoes.Add(avaliacao);
        }

        public void AdicionarProgresso(Progresso progresso)
        {
            progressos.Add(progresso);
        }
        // Método
        public void ExibirDados()
        {
            Console.WriteLine($"ID da Aula: {idAula}");
            Console.WriteLine($"Título: {tituloAula}");
            Console.WriteLine($"Conteúdo: {conteudoTexto}");
            Console.WriteLine($"Ordem: {ordem}");
        }
    }
}