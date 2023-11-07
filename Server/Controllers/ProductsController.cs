using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private static List<Product> _products = new()
    {
        new()
        {
            Id = 1,
            Title = "The Hitchhiker's Guide to the Galaxy",
            Description = "The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
            Price = 9.99m
        },
        new()
        {
            Id = 2,
            Title = "Ready Player One",
            Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
            Price = 9.99m
        },
        new()
        {
            Id = 3,
            Title = "Nineteen Eighty-Four",
            Description = "Nineteen Eighty-Four (also published as 1984) is a dystopian novel and cautionary tale by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the authoritarian state in the novel on the Soviet Union in the era of Stalinism, and Nazi Germany.[4] More broadly, the novel examines the role of truth and facts within societies and the ways in which they can be manipulated.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/51/1984_first_edition_cover.jpg",
            Price = 9.99m
        },
    };

    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        return Ok(_products);
    }
}
