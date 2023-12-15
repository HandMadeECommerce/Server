using Server.src.Core;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();

    builder.Services.AddCore(builder);
}

var app = builder.Build();
{
    app.MapGet("/", () => "Hello World!");

    app.UseHttpsRedirection();

    app.MapControllers();

    app.Run();
}