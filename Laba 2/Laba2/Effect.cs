using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Effect : IEquatable<int>
    {

        public string EffectType { get; set; }
        public float Duration { get; set; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public static bool operator ==(Effect obj1, Effect obj2)
        {
            return false;
        }

        public static bool operator !=(Effect obj1, Effect obj2)
        {

            return false;
        }
    }
}
