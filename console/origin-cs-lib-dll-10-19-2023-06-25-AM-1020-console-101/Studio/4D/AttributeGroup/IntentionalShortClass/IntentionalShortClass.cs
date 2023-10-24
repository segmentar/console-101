using Core;

namespace Core
{
    using System;

    [AttributeUsage(AttributeTargets.Class)]
    public partial class IntentionalShortClass : Attribute
    {
        public IntentionalShortClass()
        {
            return;
        }

        ~IntentionalShortClass()
        {
            return;
        }
    }
}
