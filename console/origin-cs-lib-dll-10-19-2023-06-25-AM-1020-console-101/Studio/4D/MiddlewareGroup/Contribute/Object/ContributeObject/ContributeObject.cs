using Core;

namespace Core
{
    using System;

    public partial class Contribute
    {
        [IntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Contribute) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(EnumSafe) + ':' + ' ' + EnumSafe.TabulationType,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(EnumSafe) + ':' + ' ' + EnumSafe.StringValue,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(SplitArray) + ':' + ' ' + ". . ." + ' ' + $"<{SplitArray.Length}>",
                String.Empty + '.' + "information-raw",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Indexer) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(Indexer) + ':' + ' ' + $"<safe><<{Indexer.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(Ordinal) + ':' + ' ' + Ordinal,
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(Type) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "09" + ' ' + nameof(Type) + ':' + ' ' + $"<safe><<{Type.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "10" + ' ' + nameof(Name) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "11" + ' ' + nameof(Name) + ':' + ' ' + $"<safe><<{Name.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "12" + ' ' + nameof(Value) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "13" + ' ' + nameof(Value) + ':' + ' ' + $"<safe><<{Value.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "14" + ' ' + nameof(ObjectIdentity) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(SplitArray) + ':',
                String.Empty + String.Join('\n'.ToString(), SplitArray),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(ObjectIdentity) + ':',
                String.Empty + ObjectIdentity
            });
        }
    }
}
