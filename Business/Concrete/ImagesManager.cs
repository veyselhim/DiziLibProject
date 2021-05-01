using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class ImagesManager : IImagesService
    {
        IImagesDal _filmImagesDal;

        public ImagesManager(IImagesDal filmImagesDal)
        {
            _filmImagesDal = filmImagesDal;
        }
        [ValidationAspect(typeof(ImagesValidator))]

        public IResult Add(IFormFile file, Images filmImage)
        {
            var imageCount = _filmImagesDal.GetAll(f => f.FilmId == filmImage.FilmId).Count;

            if (imageCount >= 5)
            {
                return new ErrorResult("One film must have 5 or less images");
            }

            var imageResult = FileHelper.Upload(file);

            if (!imageResult.Success)
            {
                return new ErrorResult(imageResult.Message);
            }
            filmImage.ImagePath = imageResult.Message;
            _filmImagesDal.Add(filmImage);
            return new SuccessResult("film image added");
        }
        [ValidationAspect(typeof(ImagesValidator))]
        // [SecuredOperation("admin")]
        public IResult Delete(Images filmImage)
        {
            var image = _filmImagesDal.Get(f => f.Id == filmImage.Id);
            if (image == null)
            {
                return new ErrorResult("Image not found");
            }

            FileHelper.Delete(image.ImagePath);
            _filmImagesDal.Delete(filmImage);
            return new SuccessResult("Image was deleted successfully");
        }
        [ValidationAspect(typeof(ImagesValidator))]
        [SecuredOperation("admin")]
        public IResult Update(IFormFile file, Images filmImage)
        {
            var isImage = _filmImagesDal.Get(f => f.Id == filmImage.Id);
            if (isImage == null)
            {
                return new ErrorResult("Image not found");
            }

            var updatedFile = FileHelper.Update(file, isImage.ImagePath);
            if (!updatedFile.Success)
            {
                return new ErrorResult(updatedFile.Message);
            }
            filmImage.ImagePath = updatedFile.Message;
            _filmImagesDal.Update(filmImage);
            return new SuccessResult("Car image updated");
        }
        [ValidationAspect(typeof(ImagesValidator))]
        public IDataResult<Images> Get(int id)
        {
            return new SuccessDataResult<Images>(_filmImagesDal.Get(p => p.Id == id));
        }
        // [CacheAspect]
        public IDataResult<List<Images>> GetAll()
        {
            return new SuccessDataResult<List<Images>>(_filmImagesDal.GetAll());
        }
        [ValidationAspect(typeof(ImagesValidator))]
        //[CacheAspect]
        public IDataResult<List<Images>> GetImagesByFilmId(int id)
        {
            IResult result = BusinessRules.Run(CheckIfFilmImageNull(id));

            if (result != null)
            {
                return new ErrorDataResult<List<Images>>(result.Message);
            }

            return new SuccessDataResult<List<Images>>(CheckIfFilmImageNull(id).Data);
        }


        //business rules

        private IResult CheckImageLimitExceeded(int filmid)
        {
            var filmImageCount = _filmImagesDal.GetAll(p => p.FilmId == filmid).Count;
            if (filmImageCount >= 5)
            {
                return new ErrorResult(Messages.CarImageLimitExceeded);
            }

            return new SuccessResult();
        }

        private IDataResult<List<Images>> CheckIfFilmImageNull(int id)
        {
            try
            {
                string path = @"\images\logo.jpg";
                var result = _filmImagesDal.GetAll(c => c.FilmId == id).Any();
                if (!result)
                {
                    List<Images> filmimage = new List<Images>();
                    filmimage.Add(new Images { FilmId = id, ImagePath = path, Date = DateTime.Now });
                    return new SuccessDataResult<List<Images>>(filmimage);
                }
            }
            catch (Exception exception)
            {

                return new ErrorDataResult<List<Images>>(exception.Message);
            }

            return new SuccessDataResult<List<Images>>(_filmImagesDal.GetAll(p => p.FilmId == id).ToList());
        }
        private IResult FilmImageDelete(Images filmImage)
        {
            try
            {
                File.Delete(filmImage.ImagePath);
            }
            catch (Exception exception)
            {

                return new ErrorResult(exception.Message);
            }

            return new SuccessResult();
        }
    }
}
