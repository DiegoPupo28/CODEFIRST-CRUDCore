using Microsoft.EntityFrameworkCore;
using POOII_T1_DIEGOENRIQUEZ.Datos;
using POOII_T1_DIEGOENRIQUEZ.Inicializador;

var builder = WebApplication.CreateBuilder(args);

//aca llamamos a la conexion//
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSQL")));
//estamos creando un servicio adicional a mi proyecto//
builder.Services.AddScoped<IDbInicializador, DbInicializador>();


// Add services to the container.
builder.Services.AddRazorPages();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

using(var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var inicializador = services.GetRequiredService<IDbInicializador>() as IDbInicializador;
        inicializador.Inicializar();
    }
    catch(Exception)
    {

    }
}

app.Run();
