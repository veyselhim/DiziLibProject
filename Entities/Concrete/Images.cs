using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Images : IEntity
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }

        public Images()
        {
            Date = DateTime.Now;
        }
    }
}
