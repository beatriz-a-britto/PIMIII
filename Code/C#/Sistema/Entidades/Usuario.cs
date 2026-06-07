using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Models;

public abstract class Usuario
{
    // Atributos
    private int idUsuario;
    private string nomeCompleto;
    private string cpf;
    private DateTime dataNascimento;
    private string telefone;
    private string email;
    private string senhaAcesso;
    private bool ativo;

    // Propriedades
    public int IdUsuario
    {
        get { return idUsuario; }
        set { idUsuario = value; }
    }

    public string NomeCompleto
    {
        get { return nomeCompleto; }
        set { nomeCompleto = value; }
    }

    public string CPF
    {
        get { return cpf; }
        set { cpf = value; }
    }

    public DateTime DataNascimento
    {
        get { return dataNascimento; }
        set { dataNascimento = value; }
    }

    public string Telefone
    {
        get { return telefone; }
        set { telefone = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public string SenhaAcesso
    {
        get { return senhaAcesso; }
        set { senhaAcesso = value; }
    }

    public bool Ativo
    {
        get { return ativo; }
        set { ativo = value; }
    }

    // Construtor
    protected Usuario(
        int idUsuario,
        string nomeCompleto,
        string cpf,
        DateTime dataNascimento,
        string telefone,
        string email,
        string senhaAcesso)
    {
        this.idUsuario = idUsuario;
        this.nomeCompleto = nomeCompleto;
        this.cpf = cpf;
        this.dataNascimento = dataNascimento;
        this.telefone = telefone;
        this.email = email;
        this.senhaAcesso = senhaAcesso;
        this.ativo = true;
    }

    // Método abstrato (polimorfismo)
    public abstract void ExibirPerfil();

    // Método comum para todos os usuários
    public void ExibirDados()
    {
        Console.WriteLine($"ID: {idUsuario}");
        Console.WriteLine($"Nome: {nomeCompleto}");
        Console.WriteLine($"CPF: {cpf}");
        Console.WriteLine($"Data de Nascimento: {dataNascimento:dd/MM/yyyy}");
        Console.WriteLine($"Telefone: {telefone}");
        Console.WriteLine($"E-mail: {email}");
        Console.WriteLine($"Ativo: {ativo}");
    }
  }