using System;

namespace Laba2
{
    class Effect : IEquatable<Object>
    {
        public enum EffectType { stun, poison, bite, saliva, mucus, webs, frost }
        public double Duration { get; set; }

        public Effect(string EffectType, double Duration)
        {
            this.EffectType = EffectType;
            this.Duration = Duration;
        }

        public bool EffectDo
        {
            get
            {
                if (Duration == -1)
                {
                    return true;
                }
                else
                {
                    return false;
                } 
            }
        }

        public bool Equals(Effect obj)
        {
            if (obj == null)
            {
                return false;
            }
            Effect p = obj as Effect;
            if ((Object)p == null)
            {
                return false;
            }
            return (EffectType == p.EffectType) && (Duration == p.Duration);
        }

        public int GetHashCode()
        {
            return EffectType.GetHashCode();
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
