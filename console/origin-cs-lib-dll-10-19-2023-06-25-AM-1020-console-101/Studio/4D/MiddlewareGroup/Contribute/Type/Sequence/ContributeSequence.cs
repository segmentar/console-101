using Core;

namespace Core
{
    using System;

    public partial class ContributeSequence
    {
        public Contribute Result { get; set; } = default;

        public ContributeSequence(ContributeEnumPredicate enumSafe, String[] array_SPLIT, Boolean answer_DEBUG_is)
        {
            Debug(enumSafe, array_SPLIT, answer_DEBUG_is);

            Contribute contribute;

            contribute = new Contribute(enumSafe, array_SPLIT, answer_DEBUG_is);

            switch (enumSafe.TabulationType)
            {
                case ContributeCode.TabulationType.TabulationA:
                    contribute.TabulationA();
                    break;

                case ContributeCode.TabulationType.TabulationB:
                    contribute.TabulationB();
                    break;

                case ContributeCode.TabulationType.TabulationC:
                    contribute.TabulationC();
                    break;

                case ContributeCode.TabulationType.TabulationD:
                    contribute.TabulationD();
                    break;

                default:
                    break;
            }

            this.Result = contribute;

            return;
        }

        ~ContributeSequence()
        {
            return;
        }
    }
}
