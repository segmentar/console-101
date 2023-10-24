using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public Expression ILock(String item_STRING, Boolean answer_SAFE_is)
        {
            Expression expressionResult = default;

            var list = IMod();

            Expression currentExpression;

            currentExpression = list.Last.Value;

            var StringValue__IDENTITY_STRING = item_STRING;

            var StringValueSafe___IDENTITY_STRING = ConsoleLJS.SafeString(StringValue__IDENTITY_STRING);

            var ExpressionStringSafe___IDENTITY_STRING = new ExpressionStringSafe();

            ExpressionStringSafe___IDENTITY_STRING.StringValue = StringValue__IDENTITY_STRING;

            ExpressionStringSafe___IDENTITY_STRING.StringValueSafe = StringValueSafe___IDENTITY_STRING;

            Expression expression;

            expression = MakeExpressionDefaultSurface(ExpressionStringSafe___IDENTITY_STRING, default(Object));

            if (answer_SAFE_is is true)
            {
                var boolean_CONTAIN_is = false;

                foreach (Expression expressionChild in currentExpression.ExpressionArrayList)
                {
                    Boolean isEqualCheck;

                    isEqualCheck = expressionChild.StringIdentity.Equals(item_STRING) is true;

                    if (isEqualCheck is true)
                    {
                        boolean_CONTAIN_is = true;

                        break;
                    }
                    else
                        "false".ToString();

                    continue;
                }

                if (boolean_CONTAIN_is is false)
                {
                    currentExpression.ExpressionArrayList.Add(expression);
                }
                else
                    "false".ToString();
            }
            else
            {
                currentExpression.ExpressionArrayList.Add(expression);
            }

            expressionResult = expression;

            return expressionResult;
        }
    }
}
