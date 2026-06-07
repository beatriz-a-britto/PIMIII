using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Models
{
    public class Professor : Usuario
    {
        public Professor(
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
        }

        public override void ExibirPerfil()
        {
            Console.WriteLine("Perfil: Professor");
        }
    }
}