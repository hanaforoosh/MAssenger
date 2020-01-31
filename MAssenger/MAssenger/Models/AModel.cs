using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAssenger.Models
{
    public class AModel : IEquatable<AModel>
    {
        public UInt64 Id { get; set; }
        public AModel(UInt64 id)
        {
            Id = id;
        }
        public AModel()
        {

        }
        public bool Equals(AModel other)
        {
            return this.Id == other.Id;
        }
    }
}