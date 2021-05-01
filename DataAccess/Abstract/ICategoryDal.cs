using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using DataAccess.Concrete.Entity_Framework;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {

    }
}
