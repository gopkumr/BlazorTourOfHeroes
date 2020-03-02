using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourofHeroes
{
    public class HeroService
    {
        private readonly MessageService messageService;

        public HeroService(MessageService _messageService)
        {
            this.messageService = _messageService;
        }

        public List<Hero> GetHeroes()
        {
            messageService.Add("HeroService: fetched heroes");

            return new List<Hero>()
                {
                    new Hero(){ Id=1, Name="Test1"},
                    new Hero(){ Id=2, Name="Test2"},
                    new Hero(){ Id=3, Name="Test3"},
                    new Hero(){ Id=4, Name="Test4"},
                    new Hero(){ Id=5, Name="Test5"}
                };
        }
    }
}
