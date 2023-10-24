using Core;

namespace Core
{
    using System;

    public partial class ContributeSequence
    {
        [IntentionalShortMethod]
        public static void Debug(ContributeEnumPredicate enumSafe, String[] array_SPLIT, Boolean answer_DEBUG_is)
        {
            if (answer_DEBUG_is is false)
            {
                return;
            }
            else
                "false".ToString();

            ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Debug}-{nameof(Contribute)}Debug", String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Contribute) + ' ' + "::" + ' ' + nameof(ContributeSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(enumSafe) + ':' + ' ' + enumSafe.TabulationType,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(enumSafe) + ':' + ' ' + enumSafe.StringValue,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(array_SPLIT) + ':' + ' ' + ". . ." + ' ' + $"<{array_SPLIT.Length}>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(answer_DEBUG_is) + ':' + ' ' + answer_DEBUG_is,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(array_SPLIT) + ':',
                String.Empty + String.Join('\n'.ToString(), array_SPLIT)
            }));

            return;
        }
    }
}
