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

        public bool EffectDo
        {
            get
            {
                if (Duration == -1)
                    return true;
                else
                    return false;
            }
        }

        public int GetHashCode()
        {
            return base.GetHashCode();
        }

        public bool Equals(int other)
        {
            return base.Equals(other);
        }

        public static bool operator ==(Effect eff1, Effect eff2)
        {
            if ((eff1.EffectType == eff2.EffectType) && (eff1.Duration == eff2.Duration) && (eff1.EffectDo == eff2.EffectDo))
                return true;
            return false;
        }

        public static bool operator !=(Effect eff1, Effect eff2)
        {
            if ((eff1.EffectType != eff2.EffectType) || (eff1.Duration != eff2.Duration) || (eff1.EffectDo != eff2.EffectDo))
                return true;
            return false;
        }
    }
}
