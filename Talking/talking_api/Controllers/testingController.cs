using Microsoft.AspNetCore.Mvc;

namespace talking_api.Controllers;

[ApiController]
[Route("[controller]")]
public class testingController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<testingController> _logger;

    public testingController(ILogger<testingController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetTesting")]
    public IEnumerable<Animal> Get()
    {
        List<Animal> animals= new
        Animal.Add(new Monkey{
            Nombre="Jorge",
            LevelAttack= 3,
            levelDefense= 9,
        });
        animals.Add(new Shark{
            Nombre="Tiburon",
            LevelAttack=10,
            levelDefense= 3,
        });

        return animals;
    }
}

internal class Shark : Animal
{
    public string? Nombre { get; set; }
    public int LevelAttack { get; set; }
    public int levelDefense { get; set; }
}

internal class Monkey
{
    public string? Nombre { get; set; }
    public int LevelAttack { get; set; }
    public int levelDefense { get; set; }
}

public class Animal
{
    internal class Add : List<Animal>
    {
        private Monkey monkey;

        public Add(Monkey monkey)
        {
            this.monkey = monkey;
        }
    }
}