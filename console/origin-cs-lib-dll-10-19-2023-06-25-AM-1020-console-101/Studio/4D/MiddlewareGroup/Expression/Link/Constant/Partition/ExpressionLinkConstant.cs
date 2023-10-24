using Core;

namespace Core
{
    using System;

    public partial class ExpressionConstant
    {
        public const String ExpressionExtension = "expression";
    }
}

namespace Core
{
    using System;

    public partial class ExpressionConstant
    { 
        public const String InstructionLOCK = "lock";

        public const String InstructionVLOCK = "vlock";

        public const String InstructionUNLOCK = "unlock";

        public const String InstructionVUNLOCK = "vunlock";

        public const String InstructionRELEASE = "release";

        public const String InstructionVRELEASE = "vrelease";

        public const String InstructionBRELEASE = "brelease";

        public const String InstructionBIND = "bind";

        public const String InstructionBINDINT32 = "bindint32";

        public const String InstructionVIEW = "view";

        public const String InstructionOPERATION = "operation";
    }
}

namespace Core
{
    using System;

    public partial class ExpressionConstant
    {
        public const String ValidationCSharpInt32 = "csharp-host-int32";

        public const String ValidationCSharpUInt32 = "csharp-host-uint32";
    }
}

namespace Core
{
    using System;

    public partial class ExpressionConstant
    {
        public const String OperationCSharpInt32Addition = "csharp-host-int32-addition";

        public const String OperationCSharpUInt32Addition = "csharp-host-uint32-addition";
    }
}

