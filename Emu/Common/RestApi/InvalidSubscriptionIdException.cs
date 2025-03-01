﻿namespace Emu.Common.RestApi
{
    public class InvalidSubscriptionIdException : Exception
    {
        public InvalidSubscriptionIdException(string message = "unknown exception", string? subscriptionId = "unknown") : base(message)
        {
            Data.Add("code", "InvalidSubscriptionId");
            Data.Add("message", $"The provided subscription identifier '{subscriptionId}' is malformed or invalid.");
        }
    }
}
