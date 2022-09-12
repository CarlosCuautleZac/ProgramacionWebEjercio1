var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();//Activar MVC como patron de desarrollo


var app = builder.Build();
app.UseStaticFiles();

app.UseRouting();
app.UseEndpoints(endpoints =>
    endpoints.MapDefaultControllerRoute());



app.Run();
