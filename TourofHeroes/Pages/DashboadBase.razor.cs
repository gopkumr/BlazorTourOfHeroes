using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourofHeroes.Pages
{
    public class DashboadBase:ComponentBase
    {
        [Inject]
        public HeroService _heroService
        {
            get;set;
        }
        protected List<Hero> topFive;

        protected override async Task OnInitializedAsync()
        {
            var _heroesList = await Task.FromResult(_heroService.GetHeroes());
            topFive = _heroesList.OrderByDescending(q => q.Id).Take(4).ToList();
        }
    }
}
