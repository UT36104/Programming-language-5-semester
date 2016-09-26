using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class PlayerOutfitException : ApplicationException
    {
        public PlayerOutfitException() { }
        public PlayerOutfitException(string message) : base(message) { }
        public PlayerOutfitException(string message, Exception ex) : base(message) { }

        protected PlayerOutfitException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext contex)
            : base(info, contex) { }
    }
}
