using System.Diagnostics.SymbolStore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();


app.MapGet("/", () =>
{
     var caminho = Path.Combine(app.Environment.ContentRootPath, "Program.cs");
    var codigo = System.Net.WebUtility.HtmlEncode(File.ReadAllText(caminho));

    var html = $$"""
    <!DOCTYPE html>
    <html lang="pt-br">
    <head>
      <meta charset="utf-8">
      <title>ASP.NET Core</title>
      <style>
        body { font-family: Arial, sans-serif; max-width: 900px; margin: 2rem auto; padding: 0 1rem; }
        pre { background: #f4f4f4; padding: 1rem; overflow-x: auto; }
      </style>
    </head>
    <body>
      <h1>ASP.NET Core (C#) - Nome 1, Nome 2, Nome 3</h1>
      <p>Descrição da tecnologia: ...</p>

      <h2>1. Pontos Fortes e Filosofia</h2>
      <ul>
        <li>Confiavel em auto escala: É utilizado por alguns dos maiores serviços do mundo
        Como Xbox e Microsoft 365</li>
        <li>Multimodular: Projetado para rodar nativamente em Windows, linux e macOS</li>
        <li>Otimização continua: É constantemente reformulado e lidera em rankings de performace.</li>
      </ul>
      <p><strong>Caso de uso ideal:</strong>APIs e sistemas de medio a grande porte 
       que precisam de alto desempenho, segurança, e mautenção a longo prazo, como back-end de comércios
       virtuais, sistemas financeiros ou serviços internos de empresas.<p>

      <h2>2. Pré-Requisitos e Setup</h2>
      <ul>
        <li>.NET SDK</li>
        <li>VS Code + C# Dev Kit</li>
      </ul>
      <pre>dotnet --version
    dotnet new webapi -n TodoApi -o .</pre>

      <h2>3. O Código do Servidor</h2>
      <p>Comando que rodou o servidor: <code>dotnet run</code></p>
      <pre>{{codigo}}</pre>

      <h2>4. Conclusão</h2>
      <p><strong>Principal dificuldade inicial:</strong> Entender a documentação e todos os recursos da API, visto que
      por ter tantas funcionalidades, acaba tendo uma complexidade alta no desenvolvimento</p>
      <p><strong>Recomendação final:</strong> É uma ótima API para empresas que lidam
      com um alto fluxo de informação, mas pela sua complexidade, talvez não seja a melhor para iniciantes.</p>
    </body>
    </html>
    """;

    return Results.Content(html, "text/html; charset=utf-8");
});

app.Run();


