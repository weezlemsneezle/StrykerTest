using System;

namespace StrykerTest
{
    public class Foo
    {
        public bool Bar (ushort val)
        {
            Span<ushort> kindaUnrelated = stackalloc ushort[]
            {
                0
            };
            return val == 0;
        }
    }
}
