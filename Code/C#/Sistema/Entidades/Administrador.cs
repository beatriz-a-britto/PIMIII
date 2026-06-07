using System;

namespace Sistema.Models
{
    public class Administrador : Usuario
    {
        public Administrador(
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

        public void AtivarUsuario(Usuario usuario)
        {
            usuario.Ativo = true;
        }

        public void DesativarUsuario(Usuario usuario)
        {
            usuario.Ativo = false;
        }

        public override void ExibirPerfil()
        {
            Console.WriteLine("Perfil: Administrador");
        }
    }
}