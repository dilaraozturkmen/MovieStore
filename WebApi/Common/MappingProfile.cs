using AutoMapper;
using WebApi.Application.ActorOperations.CreateActor;
using WebApi.Application.ActorOperations.GetActor;
using WebApi.Application.ActorOperations.GetActorDetail;
using WebApi.Application.ActorOperations.UpdateActor;
using WebApi.Application.CustomerOperations.CreateCustomer;
using WebApi.Application.CustomerOperations.GetCustomer;
using WebApi.Application.CustomerOperations.GetCustomerDetail;
using WebApi.Application.CustomerOperations.UpdateCustomer;
using WebApi.Application.DirectorOperations.CreateDirector;
using WebApi.Application.DirectorOperations.GetDirector;
using WebApi.Application.DirectorOperations.GetDirectorDetail;
using WebApi.Application.DirectorOperations.UpdateDirector;
using WebApi.Application.GenreOperations.CreateGenre;
using WebApi.Application.GenreOperations.GetGenre;
using WebApi.Application.GenreOperations.GetGenreDetail;
using WebApi.Application.GenreOperations.UpdateGenre;
using WebApi.Application.MovieOperations.CreateMovie;
using WebApi.Application.MovieOperations.GetDetailMovie;
using WebApi.Application.MovieOperations.GetMovie;
using WebApi.Application.MovieOperations.UpdateMovie;
using WebApi.Application.OrderOperations.CreateOrder;
using WebApi.Application.OrderOperations.GetDetailOrder;
using WebApi.Application.OrderOperations.GetOrder;
using WebApi.Application.OrderOperations.UpdateOrder;
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
             CreateMap<Actor, ActorDetailViewModel>();
             CreateMap<Director ,DirectorDetailViewModel >();
             CreateMap<Customer ,CustomerDetailViewModel >();
             CreateMap<Genre , GenreDetailViewModel>();
             CreateMap<Movie ,MovieDetailViewModel>();
             CreateMap<Order , OrderDetailViewModel>();
            
        }
    }
}