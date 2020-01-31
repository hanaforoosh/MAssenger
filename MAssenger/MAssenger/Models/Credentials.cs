using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAssenger.Models
{
    public class Credential : AModel, IEquatable<Credential>
    {
        public string Username { get; set; }

        public string Password { get; set; }
        public bool Equals(Credential other)
        {
            return this.Id == other.Id;
        }
    }
}