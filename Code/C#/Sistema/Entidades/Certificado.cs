using System;

namespace Sistema.Models
{
    public class Certificado
    {
        // Atributos
        private int idCertificado;
        private string dataEmissao;
        private int cargaHoraria;
        private string codigo;

        private Aluno aluno;
        private Curso curso;

        // Propriedades
        public int IdCertificado
        {
            get { return idCertificado; }
            set { idCertificado = value; }
        }

        public string DataEmissao
        {
            get { return dataEmissao; }
            set { dataEmissao = value; }
        }

        public int CargaHoraria
        {
            get { return cargaHoraria; }
            set { cargaHoraria = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public Aluno Aluno
        {
            get { return aluno; }
            set { aluno = value; }
        }

        public Curso Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        // Construtor
        public Certificado(
            int idCertificado,
            string dataEmissao,
            int cargaHoraria,
            string codigo,
            Aluno aluno,
            Curso curso)
        {
            this.idCertificado = idCertificado;
            this.dataEmissao = dataEmissao;
            this.cargaHoraria = cargaHoraria;
            this.codigo = codigo;
            this.aluno = aluno;
            this.curso = curso;
        }

        // Métodos
        public void Emitir()
        {
            Console.WriteLine("Certificado emitido com sucesso.");
        }

        public void Validar()
        {
            Console.WriteLine("Certificado validado.");
        }

        public void Reemitir()
        {
            Console.WriteLine("Certificado reemitido.");
        }

        public void ExibirDados()
        {
            Console.WriteLine($"ID: {idCertificado}");
            Console.WriteLine($"Data de Emissão: {dataEmissao}");
            Console.WriteLine($"Carga Horária: {cargaHoraria}");
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Aluno: {aluno.NomeCompleto}");
            Console.WriteLine($"Curso: {curso.NomeCurso}");
        }
    }
}