using AutoMapper;
using WebApi.Entities;

namespace WebApi.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
             CreateMap<CreateActorModel , Actor>();
             CreateMap<CreateDirectorModel , Director>();
             CreateMap<CreateCustomerModel , Customer>();
             CreateMap<CreateGenreModel , Genre>();
             CreateMap<CreateMovieModel , Movie>();
             CreateMap<CreateOrderModel , Order>();
             CreateMap<UpdateActorModel , Actor>();
             CreateMap<UpdateDirectorModel , Director>();
             CreateMap<UpdateCustomerModel , Customer>();
             CreateMap<UpdateGenreModel , Genre>();
             CreateMap<UpdateMovieModel , Movie>();
             CreateMap<UpdateOrderModel , Order>();
             CreateMap<Actor, ActorViewModel>();
             CreateMap<Director ,DirectorViewModel >();
             CreateMap<Customer ,CustomerViewModel >();
             CreateMap<Genre , GenreViewModel>();
             CreateMap<Movie ,MovieViewModel>();
             CreateMap<Order , OrderViewModel>();
             CreateMap<Actor_Movie, ActorMovieViewModel>();
             CreateMap<Actor, ActorDetailViewModel>();
             CreateMap<Director ,DirectorDetailViewModel >();
             CreateMap<Customer ,CustomerDetailViewModel >();
             CreateMap<Genre , GenreDetailViewModel>();
             CreateMap<Movie ,MovieDetailViewModel>();
             CreateMap<Order , OrderDetailViewModel>();
             CreateMap<Actor_Movie, ActorDetailMovieViewModel>();

             

            
        }
    }
}