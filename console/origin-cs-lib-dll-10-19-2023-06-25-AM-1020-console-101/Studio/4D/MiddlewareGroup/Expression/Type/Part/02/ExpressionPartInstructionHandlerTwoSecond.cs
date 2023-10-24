using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public void ExpressionInstructionHandlerPartTwoSecond(String[] array_STRING, Stack item_STACK, String item_STRING, String item_LOWER, String[] array_SPLIT)
        {
            switch (item_LOWER)
            {
                case ExpressionConstant.InstructionLOCK:
                    HLock(array_SPLIT);
                    break;

                case ExpressionConstant.InstructionUNLOCK:
                    HUnlock(array_SPLIT);
                    break;

                case ExpressionConstant.InstructionVLOCK:
                    HVLock(array_SPLIT);
                    break;

                case ExpressionConstant.InstructionVUNLOCK:
                    HVUnlock(array_SPLIT);
                    break;

                case ExpressionConstant.InstructionRELEASE:
                    HRelease();
                    break;

                case ExpressionConstant.InstructionVRELEASE:
                    HVRelease();
                    break;

                case ExpressionConstant.InstructionBRELEASE:
                    HBRelease();
                    break;

                case ExpressionConstant.InstructionBIND:
                    HBind(array_SPLIT);
                    break;

                case ExpressionConstant.InstructionBINDINT32:
                    HBindInt32(array_SPLIT);
                    break;

                case ExpressionConstant.InstructionVIEW:
                    HView();
                    break;

                case ExpressionConstant.InstructionOPERATION:
                    HOperation(array_SPLIT, item_STACK);
                    break;

                default:
                    break;
            }

            return;
        }
    }
}
