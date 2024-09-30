using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.Hosting;
using MinimalAPI.Dominio.Interfaces;
using Test.Mocks;
using Microsoft.Extensions.DependencyInjection;

namespace Test.Helpers
{
    public class Setup
    {
        public const string PORT = "5001";
        public static TestContext testContext = default!;  // Correção de "TestContest" para "TestContext"
        public static WebApplicationFactory<Startup> http = default!;
        public static HttpClient client = default!;

        // Inicialização da classe
        public static void ClassInit(TestContext testContext)
        {
            Setup.testContext = testContext;

            // Inicializando WebApplicationFactory
            Setup.http = new WebApplicationFactory<Startup>().WithWebHostBuilder(builder =>
            {
                builder.UseSetting("https_port", Setup.PORT)
                       .UseEnvironment("Testing");

                builder.ConfigureServices(services =>
                {
                    // Mock do serviço de administrador
                    services.AddScoped<IAdministradorServico, AdministradorServicoMock>();
                });
            });

            // Criando o HttpClient
            Setup.client = Setup.http.CreateClient();
        }

        // Limpeza dos recursos após os testes
        public static void ClassCleanup()
        {
            Setup.client.Dispose(); // Certifique-se de descartar o HttpClient
            Setup.http.Dispose();   // Limpeza da WebApplicationFactory
        }
    }
}
