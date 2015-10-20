using EmberWebApi.Backend.Models;
using System.Linq;
using System.Collections.Generic;

namespace EmberWebApi.Backend
{
    using Nancy;
    
    public class HomeModule : NancyModule
    {
        private List<Car> Cars
        {
            get
            {
                return new List<Car>()
                {
                    new Car { Id = 1, Make = "GMC", Model = "Sierra", Years = new List<Year>
                    {
                        new Year { Id = 1, Name = "'13" },
                        new Year { Id = 2, Name = "'14" },
                        new Year { Id = 3, Name = "'15" }
                    } },
                    new Car { Id = 2, Make = "Chevrolet", Model = "Silverado" },
                    new Car { Id = 3, Make = "Honda", Model = "Pilot" },
                    new Car { Id = 4, Make = "Subaru", Model = "Outback" }
                };
            }    
        }
        
        public HomeModule()
        {
            Get["/cars"] = _ => this.Cars;
            Get["/cars/{id}"] = parameters => this.Cars.FirstOrDefault(c => c.Id == parameters.id);
        }
    }
}
