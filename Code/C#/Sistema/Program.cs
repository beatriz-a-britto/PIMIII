using System;
using Sistema.Models;

namespace Sistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== TESTE DO SISTEMA =====\n");

            // =========================
            // USUÁRIOS
            // =========================

            Aluno aluno = new Aluno(
                1,
                "João Silva",
                "123.456.789-00",
                new DateTime(2000, 5, 10),
                "(12)99999-9999",
                "joao@email.com",
                "123456");

            Professor professor = new Professor(
                2,
                "Maria Souza",
                "987.654.321-00",
                new DateTime(1985, 8, 15),
                "(12)98888-8888",
                "maria@email.com",
                "123456");

            Administrador admin = new Administrador(
                3,
                "Carlos Lima",
                "111.222.333-44",
                new DateTime(1980, 1, 20),
                "(12)97777-7777",
                "admin@email.com",
                "123456");

            // =========================
            // CURSO
            // =========================

            Curso curso = new Curso(
                1,
                "C# Orientado a Objetos",
                "Curso completo de POO",
                "Intermediário",
                40);

            // =========================
            // AULA
            // =========================

            Aula aula = new Aula(
                1,
                "Introdução à POO",
                "Conceitos de encapsulamento, herança e polimorfismo",
                1,
                curso);

            curso.AdicionarAula(aula);

            // =========================
            // MATERIAL DE APOIO
            // =========================

            MaterialApoio material = new MaterialApoio(
                1,
                "Apostila POO",
                "01/06/2026",
                true,
                curso);

            curso.AdicionarMaterial(material);

            // =========================
            // MATRÍCULA
            // =========================

            aluno.MatricularCurso(curso);

            // =========================
            // AVALIAÇÃO
            // =========================

            Avaliacao avaliacao = new Avaliacao(
                1,
                "O que é POO?",
                "Paradigma de Programação",
                "Banco de Dados",
                "Sistema Operacional",
                "Linguagem de Programação",
                "Paradigma de Programação",
                aula);

            aula.AdicionarAvaliacao(avaliacao);

            // =========================
            // PROGRESSO
            // =========================

            Progresso progresso = new Progresso(
                1,
                aluno,
                aula,
                10,
                DateTime.Now,
                "Concluída");

            aluno.AdicionarProgresso(progresso);
            aula.AdicionarProgresso(progresso);

            // =========================
            // MEDALHA
            // =========================

            Medalha medalha = new Medalha(
                1,
                "Primeira Conquista",
                "Concluiu o primeiro curso",
                "medalha.png");

            UsuarioMedalha usuarioMedalha = new UsuarioMedalha(
                1,
                aluno,
                medalha,
                DateTime.Now);

            aluno.AdicionarMedalha(usuarioMedalha);

            // =========================
            // CERTIFICADO
            // =========================

            Certificado certificado = new Certificado(
                1,
                "06/06/2026",
                40,
                "CERT-001",
                aluno,
                curso);

            aluno.AdicionarCertificado(certificado);

            // =========================
            // EXIBIÇÃO DOS DADOS
            // =========================

            Console.WriteLine("=== ALUNO ===");
            aluno.ExibirPerfil();
            aluno.ExibirDados();

            Console.WriteLine();

            Console.WriteLine("=== PROFESSOR ===");
            professor.ExibirPerfil();
            professor.ExibirDados();

            Console.WriteLine();

            Console.WriteLine("=== ADMINISTRADOR ===");
            admin.ExibirPerfil();
            admin.ExibirDados();

            Console.WriteLine();

            Console.WriteLine("=== CURSO ===");
            curso.ExibirDados();

            Console.WriteLine();

            Console.WriteLine("=== AULA ===");
            aula.ExibirDados();

            Console.WriteLine();

            Console.WriteLine("=== MATERIAL DE APOIO ===");
            material.ExibirDados();

            Console.WriteLine();

            Console.WriteLine("=== AVALIAÇÃO ===");
            avaliacao.ExibirDados();

            Console.WriteLine();

            Console.WriteLine("=== PROGRESSO ===");
            progresso.ExibirDados();

            Console.WriteLine();

            Console.WriteLine("=== MEDALHA ===");
            medalha.ExibirDados();

            Console.WriteLine();

            Console.WriteLine("=== USUÁRIO MEDALHA ===");
            usuarioMedalha.ExibirDados();

            Console.WriteLine();

            Console.WriteLine("=== CERTIFICADO ===");
            certificado.ExibirDados();

            // =========================
            // TESTE DE ATIVAÇÃO
            // =========================

            Console.WriteLine();
            Console.WriteLine("=== TESTE DE USUÁRIO ATIVO ===");

            Console.WriteLine($"Antes: {aluno.Ativo}");

            admin.DesativarUsuario(aluno);

            Console.WriteLine($"Depois: {aluno.Ativo}");

            admin.AtivarUsuario(aluno);

            Console.WriteLine($"Reativado: {aluno.Ativo}");

            // =========================
            // TESTE DAS LISTAS
            // =========================

            Console.WriteLine();
            Console.WriteLine("=== TESTE DAS LISTAS ===");

            Console.WriteLine($"Cursos do aluno: {aluno.CursosMatriculados.Count}");
            Console.WriteLine($"Progressos do aluno: {aluno.Progressos.Count}");
            Console.WriteLine($"Medalhas do aluno: {aluno.Medalhas.Count}");
            Console.WriteLine($"Certificados do aluno: {aluno.Certificados.Count}");

            Console.WriteLine($"Aulas do curso: {curso.Aulas.Count}");
            Console.WriteLine($"Materiais do curso: {curso.MateriaisApoio.Count}");

            Console.WriteLine($"Avaliações da aula: {aula.Avaliacoes.Count}");
            Console.WriteLine($"Progressos da aula: {aula.Progressos.Count}");

            Console.WriteLine();
            Console.WriteLine("===== TESTE CONCLUÍDO COM SUCESSO =====");
        }
    }
}