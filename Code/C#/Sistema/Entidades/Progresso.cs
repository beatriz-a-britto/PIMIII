using System;

namespace Sistema.Models
{
    public class Progresso
    {
        // Atributos
        private int idProgresso;
        private Aluno aluno;
        private Aula aula;
        private decimal notaObtida;
        private DateTime dataTentativa;
        private string statusAula;

        // Propriedades
        public int IdProgresso
        {
            get { return idProgresso; }
            set { idProgresso = value; }
        }

        public Aluno Aluno
        {
            get { return aluno; }
            set { aluno = value; }
        }

        public Aula Aula
        {
            get { return aula; }
            set { aula = value; }
        }

        public decimal NotaObtida
        {
            get { return notaObtida; }
            set { notaObtida = value; }
        }

        public DateTime DataTentativa
        {
            get { return dataTentativa; }
            set { dataTentativa = value; }
        }

        public string StatusAula
        {
            get { return statusAula; }
            set { statusAula = value; }
        }

        // Construtor
        public Progresso(
            int idProgresso,
            Aluno aluno,
            Aula aula,
            decimal notaObtida,
            DateTime dataTentativa,
            string statusAula)
        {
            this.idProgresso = idProgresso;
            this.aluno = aluno;
            this.aula = aula;
            this.notaObtida = notaObtida;
            this.dataTentativa = dataTentativa;
            this.statusAula = statusAula;
        }

        // Método
        public void ExibirDados()
        {
            Console.WriteLine($"ID do Progresso: {idProgresso}");
            Console.WriteLine($"Aluno: {aluno.NomeCompleto}");
            Console.WriteLine($"Aula: {aula.TituloAula}");
            Console.WriteLine($"Nota: {notaObtida}");
            Console.WriteLine($"Data da Tentativa: {dataTentativa:dd/MM/yyyy}");
            Console.WriteLine($"Status: {statusAula}");
        }
    }
}