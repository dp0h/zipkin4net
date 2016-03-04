﻿using System;

namespace Criteo.Profiling.Tracing.Utils
{
    internal static class NumberUtils
    {
        public static Guid LongToGuid(long value)
        {
            var bytes = new byte[16];
            BitConverter.GetBytes(value).CopyTo(bytes, 0);
            return new Guid(bytes);
        }

        public static long GuidToLong(Guid value)
        {
            var b = value.ToByteArray();
            var blong = BitConverter.ToInt64(b, 0);
            return blong;
        }
    }
}
