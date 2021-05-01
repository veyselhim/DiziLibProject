using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IFilmService
    {

        IDataResult<List<Film>> GetAll();

        IDataResult<Film> GetById(int filmId);

        IResult Add(Film film);

        IResult Delete(Film film);

        IResult Update(Film film);
    }
}
