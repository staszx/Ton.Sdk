using System;
using System.Collections.Generic;
using System.Text;

namespace Ton.Sdk.External
{
    using System.Threading.Tasks;

    internal class Request
    {
        public uint Id { get; set; }
        public string Result { get; set; }
        public Request(uint index)
        {
            this.Id = index;
        }
    }
    
}
