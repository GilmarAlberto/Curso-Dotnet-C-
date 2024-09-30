using MinimalAPI.Dominio.Entidades;
using MinimalAPI.Infraestrutura.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration; // Namespace correto
using MinimalAPI.Dominio.Enuns; // Certifique-se de que o enum Perfil está nesse namespace
using MinimalAPI.Dominio.Servicos; // Certifique-se de que a classe AdministradorServico está nesse namespace
using System.Reflection;

namespace Test.Domain.Servicos // Corrigido para refletir a estrutura de pastas
{
    [TestClass]
    public class AdministradorServicoTest
    {
        private DbContexto CriarContextoDeTeste()
        {
            var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path = Path.GetFullPath(Path.Combine(assemblyPath ?? "", "..", "..", ".."));
            // Configurar o ConfigurationBuilder
            var builder = new ConfigurationBuilder()
                .SetBasePath(path ?? Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();
        
            var configuration = builder.Build();
            return new DbContexto(configuration);
        }
    
        [TestMethod]
        public void TestandoBuscaPorId()
        {
            // Arrange
            var context = CriarContextoDeTeste(); // Chamando o método corretamente
            context.Database.ExecuteSqlRaw("TRUNCATE TABLE Administradores");
        
            var adm = new Administrador();
            adm.Email = "teste@teste.com";
            adm.Senha = "teste";
            adm.Perfil = "Adm"; // Usando o enum corretamente
        
            var administradorServico = new AdministradorServico(context);

            // Act 
            administradorServico.Incluir(adm); 
            var admDoBanco = administradorServico.BuscaPorId(adm.Id);

            // Assert
            Assert.IsNotNull(admDoBanco, "Administrador não encontrado no banco de dados.");
            Assert.AreEqual(1, admDoBanco.Id);
        }
    }
}
