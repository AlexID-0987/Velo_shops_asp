using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Velo_shops_asp.Models
{
    public static class Testdata
    {
        public static void Init(BakeContext context)
        {
            if (!context.Velobakes.Any())
            {
                context.Velobakes.AddRange(

                    new Velobake
                    {

                        Model = "Trassa",
                        Name = "Comanche",
                        Color = "Red",
                        Price = 11287
                    },
                     new Velobake
                     {

                         Model = "Trassa007",
                         Name = "Comanche",
                         Color = "Blue",
                         Price = 10300
                     },
                     new Velobake
                     {

                         Model = "1235e",
                         Name = "Azimut",
                         Color = "Black",
                         Price = 8300
                     },
                     new Velobake
                     {

                         Model = "81",
                         Name = "Aist",
                         Color = "Orange",
                         Price = 6000
                     },
                     new Velobake
                     {

                         Model = "Travel1",
                         Name = "Comanche",
                         Color = "Black",
                         Price = 20300
                     },
                     new Velobake
                     {

                         Model = "Beby",
                         Name = "Zaika3",
                         Color = "Blue",
                         Price = 1000
                     }
                );

                context.SaveChanges();
            }
        }
    }
}
