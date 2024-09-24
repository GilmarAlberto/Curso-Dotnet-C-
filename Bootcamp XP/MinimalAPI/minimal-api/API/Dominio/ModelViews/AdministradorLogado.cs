using MinimalAPI.Dominio.Enuns;

namespace MinimalAPI.Dominio.ModelViews;

public record AdministradorLogado
{
    
    public string Email { get; set; } = default!;
    public string Perfil { get; set; } = default!; // Definindo um valor padrão do enum
    public string Token { get; set; } = default!;
}