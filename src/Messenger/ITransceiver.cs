﻿using System.Threading.Tasks;

namespace Messenger
{
    public interface ITransceiver
    {
        /// <summary>
        /// send request, receive response
        /// </summary>
        Task<IResponse> SendAsync(IRequest request);
    }
}
