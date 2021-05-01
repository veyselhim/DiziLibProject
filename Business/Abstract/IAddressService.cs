using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAddressService
    {
        IDataResult<List<Address>> GetAll();

        IDataResult<Address> GetById(int addressId);

        IResult Add(Address address);

        IResult Delete(Address address);

        IResult Update(Address address);
    }
}
