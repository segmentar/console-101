using Core;

namespace Core
{
    using System;

    public partial class Contribute
    {
        public static Contribute MakeContributeDefaultSurface(ContributeEnumPredicate enumSafe, String[] array_SPLIT)
        {
            Contribute contributeResult = default;

            contributeResult = MakeContributeDefault(enumSafe, array_SPLIT, ContributePolicy.ContributeDebugPolicy);

            return contributeResult;
        }
    }
}
