﻿using LiteNetLib.Utils;
using Lockstep.Framework;

namespace Framework.Test.LiteNetLib
{
    public class LiteNetLibNetworkReader : INetworkReader
    {
        private readonly NetDataReader _networkReaderImplementation;     

        public LiteNetLibNetworkReader(NetDataReader networkReaderImplementation = null)
        {
            _networkReaderImplementation = networkReaderImplementation ?? new NetDataReader();
        }

        public ushort GetUShort()
        {
            return _networkReaderImplementation.GetUShort();
        }

        public int[] GetIntArray()
        {
            return _networkReaderImplementation.GetIntArray();
        }

        public long GetLong()
        {
            return _networkReaderImplementation.GetLong();
        }

        public int GetInt()
        {
            return _networkReaderImplementation.GetInt();
        }

        public void SetSource(byte[] data)
        {
            _networkReaderImplementation.SetSource(data);
        }

        public ushort PeekUShort()
        {
            return _networkReaderImplementation.PeekUShort();
        }

        public byte GetByte()
        {
            return _networkReaderImplementation.GetByte();
        }

        public ulong GetULong()
        {
            return _networkReaderImplementation.GetULong();
        }

        public uint GetUInt()
        {
            return _networkReaderImplementation.GetUInt();
        }

        public byte[] GetBytesWithLength()
        {
            return _networkReaderImplementation.GetBytesWithLength();
        }
    }
}
