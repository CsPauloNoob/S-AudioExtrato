using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleAudioExtrator.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;


    [BindProperty]
    public IFormFile File { get; set; }

    public string Format { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnPost()
    {
        if (File != null)
        {
            // Obter o formato do arquivo de vídeo
            Format = Path.GetExtension(File.FileName).ToLower();

            // Verificar se o arquivo é de um formato de vídeo válido
            if (Format != ".mp4" && Format != ".mkv" && Format != ".avi" && Format != ".wmv")
            {
                ModelState.AddModelError("File", "Selecione um arquivo de vídeo válido (.mp4, .mkv, .avi, .wmv)");
                Format = null;
            }
        }

    }
}