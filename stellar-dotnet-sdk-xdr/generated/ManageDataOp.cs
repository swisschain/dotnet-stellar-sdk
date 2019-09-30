// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================

//  struct ManageDataOp
//  {
//      string64 dataName;
//      DataValue* dataValue; // set to null to clear
//  };

//  ===========================================================================
    public class ManageDataOp
    {
        public ManageDataOp()
        {
        }

        public String64 DataName { get; set; }
        public DataValue DataValue { get; set; }

        public static void Encode(XdrDataOutputStream stream, ManageDataOp encodedManageDataOp)
        {
            String64.Encode(stream, encodedManageDataOp.DataName);
            if (encodedManageDataOp.DataValue != null)
            {
                stream.WriteInt(1);
                DataValue.Encode(stream, encodedManageDataOp.DataValue);
            }
            else
            {
                stream.WriteInt(0);
            }
        }

        public static ManageDataOp Decode(XdrDataInputStream stream)
        {
            ManageDataOp decodedManageDataOp = new ManageDataOp();
            decodedManageDataOp.DataName = String64.Decode(stream);
            int DataValuePresent = stream.ReadInt();
            if (DataValuePresent != 0)
            {
                decodedManageDataOp.DataValue = DataValue.Decode(stream);
            }

            return decodedManageDataOp;
        }
    }
}