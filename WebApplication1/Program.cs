using WebApplication1.Extensions;
using WebApplication1.Middlewares;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseLogin();

app.MapWhen(context => context.Request.Path.StartsWithSegments("/login"), builder =>
{
    builder.UseLogin();
}); 

app.UseAuthorization();

app.MapControllers();

app.Run();
