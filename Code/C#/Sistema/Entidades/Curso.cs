using System;
using System.Collections.Generic;

namespace Sistema.Models
{
    public class Curso
    {
        // Atributos
        private int idCurso;
        private string nomeCurso;
        private string descricao;
        private string nivel;
        private int cargaHoraria;

        private List<Aula> aulas;
        private List<MaterialApoio> materiaisApoio;

        // Propriedades
        public int IdCurso
        {
            get { return idCurso; }
            set { idCurso = value; }
        }

        public string NomeCurso
        {
            get { return nomeCurso; }
            set { nomeCurso = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public string Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }

        public int CargaHoraria
        {
            get { return cargaHoraria; }
            set { cargaHoraria = value; }
        }

        public List<Aula> Aulas
        {
            get { return aulas; }
            set { aulas = value; }
        }

        public List<MaterialApoio> MateriaisApoio
        {
            get { return materiaisApoio; }
            set { materiaisApoio = value; }
        }

        // Construtor
        public Curso(
            int idCurso,
            string nomeCurso,
            string descricao,
            string nivel,
            int cargaHoraria)
        {
            this.idCurso = idCurso;
            this.nomeCurso = nomeCurso;
            this.descricao = descricao;
            this.nivel = nivel;
            this.cargaHoraria = cargaHoraria;

            aulas = new List<Aula>();
            materiaisApoio = new List<MaterialApoio>();
        }

        public void AdicionarAula(Aula aula)
        {
            aulas.Add(aula);
        }

        public void AdicionarMaterial(MaterialApoio material)
        {
            materiaisApoio.Add(material);
        }

        // Método
        public void ExibirDados()
        {
            Console.WriteLine($"ID do Curso: {idCurso}");
            Console.WriteLine($"Nome do Curso: {nomeCurso}");
            Console.WriteLine($"Descrição: {descricao}");
            Console.WriteLine($"Nível: {nivel}");
            Console.WriteLine($"Carga Horária: {cargaHoraria} horas");
        }
    }
}