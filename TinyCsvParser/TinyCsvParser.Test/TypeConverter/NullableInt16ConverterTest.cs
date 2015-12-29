﻿using NUnit.Framework;
using System;
using TinyCsvParser.TypeConverter;

namespace TinyCsvParser.Test.TypeConverter
{
    [TestFixture]
    public class NullableInt16ConverterTest : BaseConverterTest<Int16?>
    {
        protected override ITypeConverter<Int16?> Converter
        {
            get { return new NullableInt16Converter(); }
        }

        protected override Tuple<string, Int16?>[] SuccessTestData
        {
            get
            {
                return new [] {
                    MakeTuple(Int16.MinValue.ToString(), Int16.MinValue),
                    MakeTuple(Int16.MaxValue.ToString(), Int16.MaxValue),
                    MakeTuple(null, default(Int16?)),
                    MakeTuple(string.Empty, default(Int16?)),
                    MakeTuple("0", 0),
                    MakeTuple("-1000", -1000),
                    MakeTuple("1000", 1000)
                };
            }
        }

        protected override string[] FailTestData
        {
            get { return new[] { "a", Int32.MinValue.ToString(), Int32.MaxValue.ToString() }; }
        }
    }
}