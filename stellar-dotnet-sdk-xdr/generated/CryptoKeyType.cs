// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================

//  enum CryptoKeyType
//  {
//      KEY_TYPE_ED25519 = 0,
//      KEY_TYPE_PRE_AUTH_TX = 1,
//      KEY_TYPE_HASH_X = 2
//  };

//  ===========================================================================
    public class CryptoKeyType
    {
        public enum CryptoKeyTypeEnum
        {
            KEY_TYPE_ED25519 = 0,
            KEY_TYPE_PRE_AUTH_TX = 1,
            KEY_TYPE_HASH_X = 2,
        }

        public CryptoKeyTypeEnum InnerValue { get; set; } = default(CryptoKeyTypeEnum);

        public static CryptoKeyType Create(CryptoKeyTypeEnum v)
        {
            return new CryptoKeyType
            {
                InnerValue = v
            };
        }

        public static CryptoKeyType Decode(XdrDataInputStream stream)
        {
            int value = stream.ReadInt();
            switch (value)
            {
                case 0: return Create(CryptoKeyTypeEnum.KEY_TYPE_ED25519);
                case 1: return Create(CryptoKeyTypeEnum.KEY_TYPE_PRE_AUTH_TX);
                case 2: return Create(CryptoKeyTypeEnum.KEY_TYPE_HASH_X);
                default:
                    throw new Exception("Unknown enum value: " + value);
            }
        }

        public static void Encode(XdrDataOutputStream stream, CryptoKeyType value)
        {
            stream.WriteInt((int) value.InnerValue);
        }
    }
}