using MinimalAPI.Dominio.Entidades;
using MinimalAPI.Dominio.Interfaces;
using MinimalAPI.DTOs;
using MinimalAPI.Infraestrutura.Db;
using Microsoft.EntityFrameworkCore; // Para EF.Functions.Like

namespace MinimalAPI.Dominio.Servicos;

public class AdministradorServico : IAdministradorServico
{
    private readonly DbContexto _contexto;

    public AdministradorServico(DbContexto contexto)
    {
        _contexto = contexto;
    }

    public Administrador Incluir(Administrador administrador)
    {
        _contexto.Administradores.Add(administrador);
        _contexto.SaveChanges();

        return administrador;
    }

    public Administrador? Login(LoginDTO loginDTO)
    { 
        var adm = _contexto.Administradores
            .Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha)
            .FirstOrDefault();

        return adm;
    }

    // Adicione o parâmetro nome à função Todos
   public List<Administrador> Todos(int? pagina, string? email = null)
    {
        var query = _contexto.Administradores.AsQueryable();

        // Se a variável email não for nula ou vazia, filtra os administradores
        if (!string.IsNullOrEmpty(email))
        {
            query = query.Where(v => EF.Functions.Like(v.Email.ToLower(), $"%{email.ToLower()}%"));
        }

        int itensPorPagina = 10;

        if (pagina != null)
        {
            query = query.Skip(((int)pagina - 1) * itensPorPagina).Take(itensPorPagina);
        }

        return query.ToList();
    }

    public Administrador? BuscaPorId(int id)
    {
        return _contexto.Administradores.Where(v => v.Id == id).FirstOrDefault();
    }
}
