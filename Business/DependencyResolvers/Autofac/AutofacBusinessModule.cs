using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Entity_Framework;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<FilmManager>().As<IFilmService>().SingleInstance();
            builder.RegisterType<EfFilmDal>().As<IFilmDal>().SingleInstance();

            builder.RegisterType<ImagesManager>().As<IImagesService>().SingleInstance();
            builder.RegisterType<EfImagesDal>().As<IImagesDal>().SingleInstance();

            builder.RegisterType<ContactManager>().As<IContactService>().SingleInstance();
            builder.RegisterType<EfContactDal>().As<IContactDal>().SingleInstance();

            builder.RegisterType<AddressManager>().As<IAddressService>().SingleInstance();
            builder.RegisterType<EfAddressDal>().As<IAddressDal>().SingleInstance();

            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<JwtHelper>().As<ITokenHelper>().SingleInstance();
            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
