using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

namespace WebApi.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
             using (var context = new MovieStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<MovieStoreDbContext>>()))
           {
                
                context.Genres.AddRange(
                    new Genre {
                        id= 1,
                        Name="action"

                    },
                    new Genre{
                        id =2,
                        Name = "romance",
                    },
                    new Genre{
                        id = 3,
                        Name = "drama"
                    }


                );
                context.Actors.AddRange(
                    new Actor{
                        id =1,
                        name = "Tom",
                        surname = "Cruise"
                    },
                    new Actor{
                        id =2,
                        name = "Kate",
                        surname = "Winslet"
                    },
                    new Actor 
                    {
                        id = 3,
                        name = "Leonarda",
                        surname = "DiCaprio"
                    },
                    new Actor
                    {
                        id = 4,
                        name= "Morgan",
                        surname = "Freeman"
                    }

                );
                context.Directors.AddRange(
                    new Director{
                        id= 1,
                        name ="Frank",
                        surname ="Darabont"
                    },
                    new Director{
                        id = 2,
                        name ="James",
                        surname = "Cameron"
                    },
                    new Director{
                        id = 33,
                        name ="Tony",
                        surname = "Scott"
                    }
                );
                context.Movies.AddRange(
                    new Movie{
                        id = 1,
                        name = "Top Gun",
                        price =20,
                        genreId = 1,
                        directorId=3
                    },
                    new Movie{
                        id =2,
                        name = "Titanic",
                        price =30,
                        genreId =2,
                        directorId=2,
                    },
                    new Movie{
                        id =3,
                        name="The Shawshank Redemption",
                        price=30,
                        genreId= 3,
                        directorId = 3
                    }
                );
                context.Customers.AddRange(
                    new Customer{
                        id =1,
                        name= "Dilara",
                        surname = "Öztürkmen",
                        favoriteGenreId = 1
                    }

                );
                context.Orders.AddRange(
                    new Order{
                        id= 1,
                        customerId =1,
                        movieId =1

                    }
                );
                context.actorMovies.AddRange(
                    new Actor_Movie{
                        id =1,
                        actorId =1,
                        movieId =1
                    },
                    new Actor_Movie{
                        id = 2,
                        actorId=2,
                        movieId = 2
                    },
                    new Actor_Movie{
                        id = 3,
                        actorId=3,
                        movieId = 2
                    },
                    new Actor_Movie{
                        id = 4,
                        actorId=4,
                        movieId = 3
                    }
                );
                context.SaveChanges();


           }
        }
    }
}