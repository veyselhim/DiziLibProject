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
    public class AddressManager:IAddressService
    {
        private readonly IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public IDataResult<List<Address>> GetAll()
        {
            return new SuccessDataResult<List<Address>>(_addressDal.GetAll(), Messages.AddressesListed);
        }

        public IDataResult<Address> GetById(int addressId)
        {
            return new SuccessDataResult<Address>(_addressDal.Get(c => c.AddressId == addressId),
                Messages.AddressListed);
        }

        public IResult Add(Address address)
        {
            _addressDal.Add(address);

            return new SuccessResult(Messages.AddressAdded);
        }

        public IResult Delete(Address address)
        {
            _addressDal.Delete(address);

            return new SuccessResult(Messages.AddressDeleted);
        }

        public IResult Update(Address address)
        {
            _addressDal.Update(address);

            return new SuccessResult(Messages.AddressUpdated);
        }
    }
}
