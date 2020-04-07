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
              new Hero() { Id= 11, Name="Dr Nice" },
              new Hero() { Id= 12, Name="Narco" },
              new Hero() { Id= 13, Name="Bombasto" },
              new Hero() { Id= 14, Name="Celeritas" },
              new Hero() { Id= 15, Name="Magneta" },
              new Hero() { Id= 16, Name="RubberMan" },
              new Hero() { Id= 17, Name="Dynama" },
              new Hero() { Id= 18, Name="Dr IQ" },
              new Hero() { Id= 19, Name="Magma" },
              new Hero() { Id= 20, Name="Tornado" }
        };

        public HeroService(MessageService _messageService)
        {
            messageService = _messageService;
        }

        public List<Hero> GetHeroes()
        {
            this.Log("fetch heros");
            return MasterListOfHeros;
        }

        public List<Hero> SearchHeros(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm)) return new List<Hero>();

            Log("found hero maching "+searchTerm);
            return MasterListOfHeros.Where(q => q.Name.ToLower().StartsWith(searchTerm.ToLower())).ToList();
        }

        public Hero GetHero(int heroId)
        {
            Log("fetch hero id=" + heroId);
            var hero = MasterListOfHeros.FirstOrDefault(q => q.Id == heroId);
            return hero;
        }

        public List<Hero> AddNewHero(Hero newHero)
        {
            Log("add hero " + newHero.Id);

            MasterListOfHeros.Add(newHero);
            return MasterListOfHeros;
        }

        public List<Hero> RemoveHero(Hero hero)
        {
            Log("remove hero " + hero.Id);

            MasterListOfHeros.Remove(hero);
            return MasterListOfHeros;
        }

        public List<Hero> UpdateHero(Hero hero)
        {
            Log("update hero " + hero.Id);

            var index = MasterListOfHeros.FindIndex(q => q.Id == hero.Id);
            MasterListOfHeros[index].Name = hero.Name;
            return MasterListOfHeros;
        }

        private void Log(string message)
        {
            this.messageService.Add(string.Format("HeroService: {0}", message));
        }
    }
}
