using Core;

namespace Core
{
    using System;

    public partial class Contribute
    {
        public static Contribute MakeContributeDefault(ContributeEnumPredicate enumSafe, String[] array_SPLIT, Boolean answer_DEBUG_is)
        {
            Contribute contributeResult = default;

            var result = new ContributeSequence(enumSafe, array_SPLIT, answer_DEBUG_is).Result;

            ContributePolicy.ContributeArrayList.Add(result);

            contributeResult = result;

            return contributeResult;
        }
    }
}
