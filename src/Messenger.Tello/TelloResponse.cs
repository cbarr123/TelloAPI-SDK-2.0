﻿using System;
using System.Text;

namespace Messenger.Tello
{
    public sealed class TelloResponse : Response<string>
    {
        public TelloResponse(IResponse response) : base(response)
        {
        }

        public TelloResponse(IRequest request, Exception exception, TimeSpan timeTaken) : base(request, exception, timeTaken)
        {
        }

        public TelloResponse(IRequest request, byte[] data, TimeSpan timeTaken) : base(request, data, timeTaken)
        {
        }

        protected override string Deserialize(byte[] data)
        {
            return Encoding.UTF8.GetString(data);
        }
    }
}