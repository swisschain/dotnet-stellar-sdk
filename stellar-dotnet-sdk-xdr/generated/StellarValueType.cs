// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================

//  enum StellarValueType
//  {
//      STELLAR_VALUE_BASIC = 0,
//      STELLAR_VALUE_SIGNED = 1
//  };

//  ===========================================================================
    public class StellarValueType
    {
        public enum StellarValueTypeEnum
        {
            STELLAR_VALUE_BASIC = 0,
            STELLAR_VALUE_SIGNED = 1,
        }

        public StellarValueTypeEnum InnerValue { get; set; } = default(StellarValueTypeEnum);

        public static StellarValueType Create(StellarValueTypeEnum v)
        {
            return new StellarValueType
            {
                InnerValue = v
            };
        }

        public static StellarValueType Decode(XdrDataInputStream stream)
        {
            int value = stream.ReadInt();
            switch (value)
            {
                case 0: return Create(StellarValueTypeEnum.STELLAR_VALUE_BASIC);
                case 1: return Create(StellarValueTypeEnum.STELLAR_VALUE_SIGNED);
                default:
                    throw new Exception("Unknown enum value: " + value);
            }
        }

        public static void Encode(XdrDataOutputStream stream, StellarValueType value)
        {
            stream.WriteInt((int) value.InnerValue);
        }
    }
}