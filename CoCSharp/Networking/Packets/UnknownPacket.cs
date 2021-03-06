﻿namespace CoCSharp.Networking.Packets
{
    public class UnknownPacket : IPacket
    {
        public ushort ID { get; set; }
        public int Length { get; set; }
        public ushort Version { get; set; }

        public byte[] EncryptedData;
        public byte[] DecryptedData;

        public void ReadPacket(PacketReader reader)
        {
            DecryptedData = new byte[Length];
            reader.Read(DecryptedData, 0, Length);
        }

        public void WritePacket(PacketWriter writer)
        {
            writer.Write(EncryptedData, 0, EncryptedData.Length);
        }
    }
}
