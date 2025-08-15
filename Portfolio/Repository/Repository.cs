using Portfolio.Models;

namespace Portfolio.Repository
{
    public class Repository : IRepository
    {
        public List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project
                {
                    Tecnologies = new List<string> { "C#", "ASP.NET Core", "Blazor", "Mapperly" },
                    Title = "CONDOMY",
                    FrontImage = "",
                    Description = "",
                    Content= @"
# Bienvenido a mi proyecto ASP.NET

Este es un ejemplo de cómo manejar **Markdown** en una aplicación web.

## Características

- Conversión de Markdown a HTML.
- Soporte para *énfasis* y **negritas**.
- Bloques de código.
- Encabezados y listas.

## Código de ejemplo

```csharp
// Este es un ejemplo dentro del string de Markdown
using Markdig;

var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
var html = Markdown.ToHtml(""# Hola mundo"", pipeline);
```
"
                },
                new Project
                {
                    Tecnologies = new List<string> { "C#", "ASP.NET Core", "Markdig" },
                    Title = "Portfolio",
                    FrontImage = "",
                    Description = "",
                    Content= "Ejemplo de contenido"
                }
            };
        }
    }
}