using Microsoft.VisualStudio.TestTools.UnitTesting; // Certifique-se de que esta linha está incluída
using MinimalAPI.DTOs;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using Test.Helpers;
using MinimalAPI.Dominio.ModelViews;
namespace Test.Requests
{
    [TestClass]
    public class AdministradorRequestTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            Setup.ClassInit(testContext);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Setup.ClassCleanup();
        }

        [TestMethod]
        public async Task TestarGetSetPropriedades()
        {
            // Arrange
            var loginDTO = new LoginDTO
            {
                Email = "adm@teste.com",
                Senha = "123456"
            };

            var content = new StringContent(JsonSerializer.Serialize(loginDTO), Encoding.UTF8, "application/json");

            // Act
            var response = await Setup.client.PostAsync("/administradores/login", content);

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = await response.Content.ReadAsStringAsync();
            var admLogado = JsonSerializer.Deserialize<AdministradorLogado>(result, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // Use isso se necessário
            });

            Assert.IsNotNull(admLogado);
            Assert.IsNotNull(admLogado.Email);
            Assert.IsNotNull(admLogado.Perfil);
            Assert.IsNotNull(admLogado.Token);

            Console.WriteLine(admLogado?.Token);
        }
    }
}
