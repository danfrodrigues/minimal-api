var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (MinimalApi.DTOs.LoginDTO loginDTO) => {
    if(loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "123456"){
        return Results.Ok("Login realizado com sucesso!");
    } 
    else{
        Results.Unauthorized();
    }
});

app.Run();