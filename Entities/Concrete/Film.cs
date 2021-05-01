using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Film:IEntity
    {
        public int FilmId { get; set; }
        public string CountryName{ get; set; }
        public string FilmName { get; set; }
        public int CategoryId { get; set; }
        public string ConstructionYear { get; set; }
        public string Language { get; set; }
        public float ImdbScore { get; set; }


    }
}
