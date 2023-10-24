using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public void ExpressionInstructionHandlerPartOneFirst(String[] array_STRING, Stack item_STACK, String item_STRING)
        {
            var entity__WHITE_SPACE = Convert.ToChar(32);

            var separator = new String[] { entity__WHITE_SPACE.ToString() };

            var split = item_STRING.Split(separator, StringSplitOptions.None);

            var oth = split[0];

            var lower = oth.ToLower();

            ExpressionInstructionHandlerPartTwoSecond(array_STRING, item_STACK, item_STRING, lower, split);

            return;
        }
    }
}
