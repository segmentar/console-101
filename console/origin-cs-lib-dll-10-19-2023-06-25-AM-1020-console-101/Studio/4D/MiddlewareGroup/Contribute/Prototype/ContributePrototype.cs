using Core;

namespace Core
{
    using System;

    public partial class Contribute
    {
        public Contribute(ContributeEnumPredicate enumSafe, String[] splitArray, Boolean debug)
        {
            this.EnumSafe = enumSafe;

            this.SplitArray = splitArray;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
