using System;

namespace Sistema.Models
{
    public class MaterialApoio
    {
        // Atributos
        private int idMaterial;
        private string titulo;
        private string dataPublicacao;
        private bool visivel;

        private Curso curso;

        // Propriedades
        public int IdMaterial
        {
            get { return idMaterial; }
            set { idMaterial = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string DataPublicacao
        {
            get { return dataPublicacao; }
            set { dataPublicacao = value; }
        }

        public bool Visivel
        {
            get { return visivel; }
            set { visivel = value; }
        }

        public Curso Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        // Construtor
        public MaterialApoio(
            int idMaterial,
            string titulo,
            string dataPublicacao,
            bool visivel,
            Curso curso)
        {
            this.idMaterial = idMaterial;
            this.titulo = titulo;
            this.dataPublicacao = dataPublicacao;
            this.visivel = visivel;
            this.curso = curso;
        }

        // Métodos
        public void Publicar()
        {
            visivel = true;
        }

        public void Renderizar()
        {
            Console.WriteLine($"Material: {titulo}");
        }

        public void ExibirDados()
        {
            Console.WriteLine($"ID: {idMaterial}");
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Data de Publicação: {dataPublicacao}");
            Console.WriteLine($"Visível: {visivel}");
        }
    }
}
