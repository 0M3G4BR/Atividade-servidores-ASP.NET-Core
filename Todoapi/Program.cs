var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content("""
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <title>Trabalho C# - ASP.NET Core</title>
    <style>
        body { font-family: Arial, sans-serif; margin: 30px; line-height: 1.5; }
        h1, h2 { color: #512bd4; }
        pre { background: #f4f4f4; padding: 10px; border-radius: 5px; }
    </style>
</head>
<body>
    <h1>Linguagem: C# | Framework: ASP.NET Core</h1>
    <p><strong>Integrantes:</strong> George Lucas Soares da Silva e Caue Sinkewicz dos Santos
</p>

    <h2>Seção 1: Pontos Fortes e Filosofia</h2>
    <ul>
        <li><strong>Alta Performance:</strong> Um dos frameworks mais rápidos do mercado.</li>
        <li><strong>Tipagem Forte:</strong> Previne erros durante a compilação.</li>
        <li><strong>Multiplataforma:</strong> Roda em Windows, Linux e macOS.</li>
    </ul>
    <p><strong>Caso de Uso Ideal:</strong> Sistemas corporativos de grande porte e APIs de alto desempenho.</p>

    <h2>Seção 2: Pré-Requisitos e Setup</h2>
    <p><strong>Softwares:</strong> .NET SDK e Visual Studio Code.</p>
    <p><strong>Comando para rodar:</strong> <code>dotnet run</code></p>

    <h2>Seção 3: O Código do Servidor</h2>
    <pre><code>
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content("HTML da documentacao", "text/html; charset=utf-8"));

app.Run();
    </code></pre>

    <h2>Seção 4: Conclusão</h2>
    <p><strong>Dificuldade inicial:</strong> Entender a estrutura e compilação do .NET para quem vem do JavaScript/Node.js.</p>
    <p><strong>Recomendação:</strong> Excelente para projetos que exigem desempenho, segurança e organização.</p>
</body>
</html>
""", "text/html; charset=utf-8"));

app.Run();