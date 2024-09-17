using MinimalAPI.Dominio.Enuns;

namespace MinimalAPI.Dominio.ModelViews;

public record AdministradorModelView
{
    public int Id { get; set; } = default!;
    public string Email { get; set; } = default!;
    public Perfil Perfil { get; set; } = Perfil.adm; // Definindo um valor padrão do enum
}
