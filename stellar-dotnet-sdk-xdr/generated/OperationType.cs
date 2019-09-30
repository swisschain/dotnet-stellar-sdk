// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================

//  enum OperationType
//  {
//      CREATE_ACCOUNT = 0,
//      PAYMENT = 1,
//      PATH_PAYMENT_STRICT_RECEIVE = 2,
//      MANAGE_SELL_OFFER = 3,
//      CREATE_PASSIVE_SELL_OFFER = 4,
//      SET_OPTIONS = 5,
//      CHANGE_TRUST = 6,
//      ALLOW_TRUST = 7,
//      ACCOUNT_MERGE = 8,
//      INFLATION = 9,
//      MANAGE_DATA = 10,
//      BUMP_SEQUENCE = 11,
//      MANAGE_BUY_OFFER = 12,
//      PATH_PAYMENT_STRICT_SEND = 13
//  };

//  ===========================================================================
    public class OperationType
    {
        public enum OperationTypeEnum
        {
            CREATE_ACCOUNT = 0,
            PAYMENT = 1,
            PATH_PAYMENT_STRICT_RECEIVE = 2,
            MANAGE_SELL_OFFER = 3,
            CREATE_PASSIVE_SELL_OFFER = 4,
            SET_OPTIONS = 5,
            CHANGE_TRUST = 6,
            ALLOW_TRUST = 7,
            ACCOUNT_MERGE = 8,
            INFLATION = 9,
            MANAGE_DATA = 10,
            BUMP_SEQUENCE = 11,
            MANAGE_BUY_OFFER = 12,
            PATH_PAYMENT_STRICT_SEND = 13,
        }

        public OperationTypeEnum InnerValue { get; set; } = default(OperationTypeEnum);

        public static OperationType Create(OperationTypeEnum v)
        {
            return new OperationType
            {
                InnerValue = v
            };
        }

        public static OperationType Decode(XdrDataInputStream stream)
        {
            int value = stream.ReadInt();
            switch (value)
            {
                case 0: return Create(OperationTypeEnum.CREATE_ACCOUNT);
                case 1: return Create(OperationTypeEnum.PAYMENT);
                case 2: return Create(OperationTypeEnum.PATH_PAYMENT_STRICT_RECEIVE);
                case 3: return Create(OperationTypeEnum.MANAGE_SELL_OFFER);
                case 4: return Create(OperationTypeEnum.CREATE_PASSIVE_SELL_OFFER);
                case 5: return Create(OperationTypeEnum.SET_OPTIONS);
                case 6: return Create(OperationTypeEnum.CHANGE_TRUST);
                case 7: return Create(OperationTypeEnum.ALLOW_TRUST);
                case 8: return Create(OperationTypeEnum.ACCOUNT_MERGE);
                case 9: return Create(OperationTypeEnum.INFLATION);
                case 10: return Create(OperationTypeEnum.MANAGE_DATA);
                case 11: return Create(OperationTypeEnum.BUMP_SEQUENCE);
                case 12: return Create(OperationTypeEnum.MANAGE_BUY_OFFER);
                case 13: return Create(OperationTypeEnum.PATH_PAYMENT_STRICT_SEND);
                default:
                    throw new Exception("Unknown enum value: " + value);
            }
        }

        public static void Encode(XdrDataOutputStream stream, OperationType value)
        {
            stream.WriteInt((int) value.InnerValue);
        }
    }
}