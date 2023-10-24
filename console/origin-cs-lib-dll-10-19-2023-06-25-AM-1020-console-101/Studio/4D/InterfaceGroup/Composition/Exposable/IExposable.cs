using Core;

namespace Core
{
    using System;

    public partial interface IExposable<T>
    { 
        T ExposeReference();

        T CleanReference();
    }
}
