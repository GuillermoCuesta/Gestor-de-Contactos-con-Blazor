using Gestor_de_Contactos.Client;  // Aseg�rate de que los espacios de nombres sean correctos
using Gestor_de_Contactos.Client.Interfaces;  // Aseg�rate de que los espacios de nombres sean correctos
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;  // Aseg�rate de que el espacio de nombres sea correcto
using Microsoft.Extensions.DependencyInjection;  // Aseg�rate de que el espacio de nombres sea correcto
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

        // Cargar la configuraci�n desde appsettings.json
        builder.Configuration.AddJsonFile("appsettings.json");

        // Obtener la cadena de conexi�n desde la configuraci�n
        string dbConnection = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddSingleton(sp => new SqlConnection(dbConnection));

        // Registrar la implementaci�n concreta de IContactService
        builder.Services.AddScoped<IContactService, ContactService>();

        await builder.Build().RunAsync();
    }
}
