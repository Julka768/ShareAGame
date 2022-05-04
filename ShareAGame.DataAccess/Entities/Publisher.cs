using ShareAGame.DataAccess.Models;
using System;
using System.Collections.Generic;

namespace ShareAGame.DataAccess.Entities
{
    public class Publisher
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Game> Games { get; set; } = new List<Game>();
        //country

    }
}
