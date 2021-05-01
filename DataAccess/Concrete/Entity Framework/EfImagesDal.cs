using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfImagesDal : EfEntityRepositoryBase<Images, NetflixDemoContext>, IImagesDal
    {
    }
}
