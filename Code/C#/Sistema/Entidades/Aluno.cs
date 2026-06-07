using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Models
{
    public class Aluno : Usuario
    {
        // Atributos
        private List<Curso> cursosMatriculados;
        private List<UsuarioMedalha> medalhas;
        private List<Progresso> progressos;
        private List<Certificado> certificados;

        // Propriedades
        public List<Curso> CursosMatriculados
        {
            get { return cursosMatriculados; }
            set { cursosMatriculados = value; }
        }

        public List<UsuarioMedalha> Medalhas
        {
            get { return medalhas; }
            set { medalhas = value; }
        }

        public List<Progresso> Progressos
        {
            get { return progressos; }
            set { progressos = value; }
        }

        public List<Certificado> Certificados
        {
            get { return certificados; }
            set { certificados = value; }
        }

        // Construtor
        public Aluno(
            int idUsuario,
            string nomeCompleto,
            string cpf,
            DateTime dataNascimento,
            string telefone,
            string email,
            string senhaAcesso)
            : base(
                idUsuario,
                nomeCompleto,
                cpf,
                dataNascimento,
                telefone,
                email,
                senhaAcesso)
        {
            cursosMatriculados = new List<Curso>();
            medalhas = new List<UsuarioMedalha>();
            progressos = new List<Progresso>();
            certificados = new List<Certificado>();
        }

        public void MatricularCurso(Curso curso)
        {
            cursosMatriculados.Add(curso);
        }

        public void AdicionarMedalha(UsuarioMedalha medalha)
        {
            medalhas.Add(medalha);
        }

        public void AdicionarCertificado(Certificado certificado)
        {
            certificados.Add(certificado);
        }

        public void AdicionarProgresso(Progresso progresso)
        {
            progressos.Add(progresso);
        }
        // Polimorfismo
        public override void ExibirPerfil()
        {
            Console.WriteLine("Perfil: Aluno");
        }
    }
}