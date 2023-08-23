using Gestor_de_Contactos.Client;  // Asegúrate de que los espacios de nombres sean correctos
using Gestor_de_Contactos.Client.Interfaces;  // Asegúrate de que los espacios de nombres sean correctos
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;  // Asegúrate de que el espacio de nombres sea correcto
using Microsoft.Extensions.DependencyInjection;  // Asegúrate de que el espacio de nombres sea correcto
using System;
using System.Net.Http;
using Microsoft.Data.SqlClient;
using Gestor_de_Contactos.Client.Services;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);

        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

        // Cargar la configuración desde appsettings.json
        builder.Configuration.AddJsonFile("appsettings.json");

        // Obtener la cadena de conexión desde la configuración
        string dbConnection = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddSingleton(sp => new SqlConnection(dbConnection));

        // Registrar la implementación concreta de IContactService
        builder.Services.AddScoped<IContactService, ContactService>();

        await builder.Build().RunAsync();
    }
}
