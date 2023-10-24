using Core;

namespace Core
{
    using System;

    public partial struct ContributeModule
    {
        public static ContributeModule ContributeModuleDefault(Contribute[] array_CONTRIBUTE)
        {
            ContributeModule module;

            module = new ContributeModule();

            module.ContributeArray = array_CONTRIBUTE;

            module = ContributeModuleOne(module);

            return module;
        }
    }
}
