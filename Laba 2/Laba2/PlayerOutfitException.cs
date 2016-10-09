using System;

namespace Laba2
{
    public class PlayerOutfitException : ApplicationException
    {
        public PlayerOutfitException() { }
        public PlayerOutfitException(string message) : base(message) { }

        protected PlayerOutfitException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext contex)
            : base(info, contex) { }
    }
}
