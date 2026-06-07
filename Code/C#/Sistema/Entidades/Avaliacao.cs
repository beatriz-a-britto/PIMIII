using System;

namespace Sistema.Models
{
    public class Avaliacao
    {
        // Atributos
        private int idAvaliacao;
        private string pergunta;
        private string opcaoA;
        private string opcaoB;
        private string opcaoC;
        private string opcaoD;
        private string respostaCorreta;

        private Aula aula;

        // Propriedades
        public int IdAvaliacao
        {
            get { return idAvaliacao; }
            set { idAvaliacao = value; }
        }

        public string Pergunta
        {
            get { return pergunta; }
            set { pergunta = value; }
        }

        public string OpcaoA
        {
            get { return opcaoA; }
            set { opcaoA = value; }
        }

        public string OpcaoB
        {
            get { return opcaoB; }
            set { opcaoB = value; }
        }

        public string OpcaoC
        {
            get { return opcaoC; }
            set { opcaoC = value; }
        }

        public string OpcaoD
        {
            get { return opcaoD; }
            set { opcaoD = value; }
        }

        public string RespostaCorreta
        {
            get { return respostaCorreta; }
            set { respostaCorreta = value; }
        }

        public Aula Aula
        {
            get { return aula; }
            set { aula = value; }
        }

        // Construtor
        public Avaliacao(
            int idAvaliacao,
            string pergunta,
            string opcaoA,
            string opcaoB,
            string opcaoC,
            string opcaoD,
            string respostaCorreta,
            Aula aula)
        {
            this.idAvaliacao = idAvaliacao;
            this.pergunta = pergunta;
            this.opcaoA = opcaoA;
            this.opcaoB = opcaoB;
            this.opcaoC = opcaoC;
            this.opcaoD = opcaoD;
            this.respostaCorreta = respostaCorreta;
            this.aula = aula;
        }

        // Método
        public void ExibirDados()
        {
            Console.WriteLine($"ID da Avaliação: {idAvaliacao}");
            Console.WriteLine($"Pergunta: {pergunta}");
            Console.WriteLine($"A) {opcaoA}");
            Console.WriteLine($"B) {opcaoB}");
            Console.WriteLine($"C) {opcaoC}");
            Console.WriteLine($"D) {opcaoD}");
            Console.WriteLine($"Resposta Correta: {respostaCorreta}");
        }
    }
}