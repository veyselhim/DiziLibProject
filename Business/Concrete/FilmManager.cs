using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class FilmManager : IFilmService
    {
        private readonly IFilmDal _filmDal;

        public FilmManager(IFilmDal filmDal)
        {
            _filmDal = filmDal;
        }

        public IDataResult<List<Film>> GetAll()
        {
            return new SuccessDataResult<List<Film>>(_filmDal.GetAll(), Messages.FilmListed);
        }

        public IDataResult<Film> GetById(int filmId)
        {
            return new SuccessDataResult<Film>(_filmDal.Get(c => c.FilmId == filmId),
                Messages.FilmListed);
        }

        public IResult Add(Film film)
        {
            _filmDal.Add(film);

            return new SuccessResult(Messages.FilmAdded);
        }

        public IResult Delete(Film film)
        {
            _filmDal.Delete(film);

            return new SuccessResult(Messages.FilmDeleted);
        }

        public IResult Update(Film film)
        {
            _filmDal.Update(film);

            return new SuccessResult(Messages.FilmUpdated);
        }
    }
}
