// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================

//  struct Liabilities
//  {
//      int64 buying;
//      int64 selling;
//  };

//  ===========================================================================
    public class Liabilities
    {
        public Liabilities()
        {
        }

        public Int64 Buying { get; set; }
        public Int64 Selling { get; set; }

        public static void Encode(XdrDataOutputStream stream, Liabilities encodedLiabilities)
        {
            Int64.Encode(stream, encodedLiabilities.Buying);
            Int64.Encode(stream, encodedLiabilities.Selling);
        }

        public static Liabilities Decode(XdrDataInputStream stream)
        {
            Liabilities decodedLiabilities = new Liabilities();
            decodedLiabilities.Buying = Int64.Decode(stream);
            decodedLiabilities.Selling = Int64.Decode(stream);
            return decodedLiabilities;
        }
    }
}