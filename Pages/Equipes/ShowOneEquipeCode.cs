using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using projetASSagy_front1.Classes;

namespace projetASSagy_front1.Pages;

public class ShowOneEquipeCode : ComponentBase
{
    [Parameter]
    public string Id { get; set; }

    public Equipe equipe { get; set; }
    
}