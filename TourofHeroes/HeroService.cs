using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourofHeroes
{
    public class HeroService
    {
        private readonly MessageService messageService;
        private List<Hero> MasterListOfHeros = new List<Hero>()
        {
            new Hero() { Id = 1, Name = "Test1" },
            new Hero() { Id = 2, Name = "Test2" },
            new Hero() { Id = 3, Name = "Test3" },
            new Hero() { Id = 4, Name = "Test4" },
            new Hero() { Id = 5, Name = "Test5" }
        };

        public HeroService(MessageService _messageService)
        {
            messageService = _messageService;
        }

        public List<Hero> GetHeroes()
        {
            //messageService.Add("HeroService: fetched heroes");
            return MasterListOfHeros;
        }

        public List<Hero> SearchHeros(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm)) return new List<Hero>();
            //messageService.Add("HeroService: fetched heroes");
            return MasterListOfHeros.Where(q => q.Name.ToLower().StartsWith(searchTerm.ToLower())).ToList();
        }

        public List<Hero> AddNewHero(Hero newHero)
        {
            //messageService.Add("HeroService: fetched heroes");

            MasterListOfHeros.Add(newHero);
            return MasterListOfHeros;
        }
    }
}
