using Microsoft.AspNetCore.Mvc;

namespace Projeto1.Controllers;

public class TestadorController : Controller
{
    private List<string> nomesTeste;

    public TestadorController()
    {
        nomesTeste = new List<string>();
        nomesTeste.Add("Julio");
        nomesTeste.Add("Gabriel");
        nomesTeste.Add("Otaviano");
        nomesTeste.Add("Amanda");
        nomesTeste.Add("Bento");
        nomesTeste.Add("Claudio");
        nomesTeste.Add("Freitas");
    }

    public List<string> Index()
    {
        return nomesTeste;
    }
}