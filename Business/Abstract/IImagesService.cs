using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface IImagesService
    {
        IResult Add(IFormFile file, Images filmImage);
        IResult Delete(Images filmImage);
        IResult Update(IFormFile file, Images filmImage);
        IDataResult<Images> Get(int id);
        IDataResult<List<Images>> GetAll();
        IDataResult<List<Images>> GetImagesByFilmId(int id);
    }
}
