﻿using System;
using System.Collections.Generic;

namespace PintoNS.Networking
{
    public static class Packets
    {
        private static Dictionary<int, Type> PacketMap = new Dictionary<int, Type>();

        static Packets() 
        {
            PacketMap.Add(0, typeof(PacketLogin));
            PacketMap.Add(1, typeof(PacketRegister));
            PacketMap.Add(2, typeof(PacketLogout));
            PacketMap.Add(3, typeof(PacketMessage));
            PacketMap.Add(4, typeof(PacketPopup));
            PacketMap.Add(5, typeof(PacketInWindowPopup));
            PacketMap.Add(6, typeof(PacketAddContact));
            PacketMap.Add(7, typeof(PacketRemoveContact));
            PacketMap.Add(8, typeof(PacketStatus));
            PacketMap.Add(9, typeof(PacketContactRequest));
            PacketMap.Add(10, typeof(PacketClearContacts));
            PacketMap.Add(11, typeof(PacketCallChangeStatus));
            PacketMap.Add(12, typeof(PacketSetOption));
            PacketMap.Add(17, typeof(PacketServerID));
            PacketMap.Add(18, typeof(PacketTyping));
            PacketMap.Add(255, typeof(PacketKeepAlive));
        }

        public static IPacket GetPacketByID(int id) 
        {
            if (PacketMap.TryGetValue(id, out Type packetType)) 
            {
                if (typeof(IPacket).IsAssignableFrom(packetType)) 
                {
                    return (IPacket) Activator.CreateInstance(packetType);
                }
            }

            return null;
        }
    }
}
