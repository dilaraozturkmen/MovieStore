using AutoMapper;
using WebApi.Application.CreateActor;
using WebApi.Application.CreateCustomer;
using WebApi.Application.CreateDirector;
using WebApi.Application.CreateGenre;
using WebApi.Application.CreateMovie;
using WebApi.Application.CreateOrder;
using WebApi.Application.GetActor;
using WebApi.Application.GetActorDetail;
using WebApi.Application.GetCustomer;
using WebApi.Application.GetCustomerDetail;
using WebApi.Application.GetDetailMovie;
using WebApi.Application.GetDetailOrder;
using WebApi.Application.GetDirector;
using WebApi.Application.GetDirectorDetail;
using WebApi.Application.GetGenre;
using WebApi.Application.GetGenreDetail;
using WebApi.Application.GetMovie;
using WebApi.Application.GetOrder;
using WebApi.Application.UpdateActor;
using WebApi.Application.UpdateCustomer;
using WebApi.Application.UpdateDirector;
using WebApi.Application.UpdateGenre;
using WebApi.Application.UpdateMovie;
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