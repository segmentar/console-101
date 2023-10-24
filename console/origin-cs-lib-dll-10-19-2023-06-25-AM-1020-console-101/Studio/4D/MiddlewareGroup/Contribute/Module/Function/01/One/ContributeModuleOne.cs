using Core;

namespace Core
{
    using System;

    public partial struct ContributeModule
    {
        public static ContributeModule ContributeModuleOne(ContributeModule module)
        {
            var con = new ContributeModule();

            ContributeModuleFirst first;

            first = new ContributeModuleFirst();

            module.First = first;

            return module;
        }
    }
}
