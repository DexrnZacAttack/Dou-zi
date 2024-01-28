using PintoNS.Networking.Packets;

namespace PintoNS.Networking
{
    public class NetBaseHandler
    {
        public const int USERNAME_MAX = 16;
        public INetworkManager NetManager;
        public string Username;
        public bool ConnectionClosed;

        public virtual void SendPacket(IPacket packet)
        {
            if (!(packet is PacketKeepAlive))
                Program.Console.WriteMessage($"Added {packet.GetType().Name} to the send queue", DouZiResources.ConsoleTypes.NETWORKING);
            NetManager.AddToQueue(packet);
            NetManager.Interrupt();
        }

        public virtual void HandleTermination(string reason)
        {
            if (ConnectionClosed) return;
            Program.Console.WriteMessage($"Disconnected: {reason}", DouZiResources.ConsoleTypes.NETWORKING);
            ConnectionClosed = true;
            OnDisconnect();
        }

        public virtual void HandlePacket(IPacket packet)
        {
            OnBadPacket();
        }

        public virtual void OnUpdate()
        {
        }

        protected virtual void OnBadPacket()
        {
            NetManager.Shutdown("Illegal packet during session type");
        }

        protected virtual void OnDisconnect()
        {
        }
    }
}