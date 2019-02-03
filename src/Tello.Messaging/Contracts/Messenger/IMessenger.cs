﻿using System.Threading.Tasks;

namespace Tello.Messaging
{
    public enum MessengerStates
    {
        Disconnected,
        Connecting,
        Connected
    }

    public interface IMessenger
    {
        MessengerStates State { get; }

        void Connect();
        void Disconnect();

        Task<IResponse> SendAsync(IRequest request);
    }
}