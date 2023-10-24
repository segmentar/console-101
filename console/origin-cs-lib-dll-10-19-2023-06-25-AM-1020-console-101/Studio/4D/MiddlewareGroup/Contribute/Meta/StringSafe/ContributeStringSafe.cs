using Core;

namespace Core
{
    using System;

    public partial struct ContributeStringSafe : IStringSafe
    {
        public String StringValue { get; set; }
        public String StringValueSafe { get; set; }
    }
}
