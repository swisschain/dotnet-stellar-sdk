// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================

//  struct BucketMetadata
//  {
//      // Indicates the protocol version used to create / merge this bucket.
//      uint32 ledgerVersion;
//  
//      // reserved for future use
//      union switch (int v)
//      {
//      case 0:
//          void;
//      }
//      ext;
//  };

//  ===========================================================================
    public class BucketMetadata
    {
        public BucketMetadata()
        {
        }

        public Uint32 LedgerVersion { get; set; }
        public BucketMetadataExt Ext { get; set; }

        public static void Encode(XdrDataOutputStream stream, BucketMetadata encodedBucketMetadata)
        {
            Uint32.Encode(stream, encodedBucketMetadata.LedgerVersion);
            BucketMetadataExt.Encode(stream, encodedBucketMetadata.Ext);
        }

        public static BucketMetadata Decode(XdrDataInputStream stream)
        {
            BucketMetadata decodedBucketMetadata = new BucketMetadata();
            decodedBucketMetadata.LedgerVersion = Uint32.Decode(stream);
            decodedBucketMetadata.Ext = BucketMetadataExt.Decode(stream);
            return decodedBucketMetadata;
        }

        public class BucketMetadataExt
        {
            public BucketMetadataExt()
            {
            }

            public int Discriminant { get; set; } = new int();

            public static void Encode(XdrDataOutputStream stream, BucketMetadataExt encodedBucketMetadataExt)
            {
                stream.WriteInt((int) encodedBucketMetadataExt.Discriminant);
                switch (encodedBucketMetadataExt.Discriminant)
                {
                    case 0:
                        break;
                }
            }

            public static BucketMetadataExt Decode(XdrDataInputStream stream)
            {
                BucketMetadataExt decodedBucketMetadataExt = new BucketMetadataExt();
                int discriminant = stream.ReadInt();
                decodedBucketMetadataExt.Discriminant = discriminant;
                switch (decodedBucketMetadataExt.Discriminant)
                {
                    case 0:
                        break;
                }

                return decodedBucketMetadataExt;
            }
        }
    }
}