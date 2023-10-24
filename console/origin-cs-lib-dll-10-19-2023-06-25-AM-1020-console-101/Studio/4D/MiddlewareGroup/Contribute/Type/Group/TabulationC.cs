using Core;

namespace Core
{
    using System;

    public partial class Contribute
    {
        public void TabulationA()
        {
            var second = SplitArray[1];

            var third = SplitArray[2];

            var fourth = SplitArray[3];

            var fifth = SplitArray[4];

            var sixth = SplitArray[5];

            var entity__DASH = Convert.ToChar(45);

            var position = third.IndexOf(entity__DASH);

            var aoth = third.Length;

            var start = (position + entity__DASH.ToString().Length);

            var difference = (aoth - start);

            var sub = third.Substring(start, difference);

            var parse = Int32.Parse(sub);

            String stringIndexer, stringIndexerSafe;

            stringIndexer = second;

            stringIndexerSafe = ConsoleLJS.SafeString(stringIndexer);

            ContributeStringSafe contributeStringSafeIndexer;

            contributeStringSafeIndexer = new ContributeStringSafe();

            contributeStringSafeIndexer.StringValue = stringIndexer;

            contributeStringSafeIndexer.StringValueSafe = stringIndexerSafe;

            String stringType, stringTypeSafe;

            stringType = fourth;

            stringTypeSafe = ConsoleLJS.SafeString(stringType);

            String stringName, stringNameSafe;

            stringName = fifth;

            stringNameSafe = ConsoleLJS.SafeString(stringName);

            String stringValue, stringValueSafe;

            stringValue = sixth;

            stringValueSafe = ConsoleLJS.SafeString(stringValue);

            ContributeStringSafe contributeStringSafeType, contributeStringSafeName, contributeStringSafeValue;

            contributeStringSafeType = new ContributeStringSafe();

            contributeStringSafeType.StringValue = stringType;

            contributeStringSafeType.StringValueSafe = stringTypeSafe;

            contributeStringSafeName = new ContributeStringSafe();

            contributeStringSafeName.StringValue = stringName;

            contributeStringSafeName.StringValueSafe = stringNameSafe;

            contributeStringSafeValue = new ContributeStringSafe();

            contributeStringSafeValue.StringValue = stringValue;

            contributeStringSafeValue.StringValueSafe = stringValueSafe;

            Indexer = contributeStringSafeIndexer;

            Ordinal = parse;

            Type = contributeStringSafeType;

            Name = contributeStringSafeName;

            Value = contributeStringSafeValue;

            return;
        }
    }
}
