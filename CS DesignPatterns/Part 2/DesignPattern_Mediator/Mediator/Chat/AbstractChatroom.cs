﻿using Mediator.PartChat;

namespace Mediator.Chat
{
    /// <summary>
    /// The 'Mediator' abstract class
    /// </summary>
    abstract class AbstractChatroom
    {
        public abstract void Register(Participant participant);
        public abstract void Send(
          string from, string to, string message);
    }
}
