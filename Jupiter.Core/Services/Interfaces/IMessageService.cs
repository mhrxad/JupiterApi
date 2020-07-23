﻿using Jupiter.DataLayer.Entities.Message;
using System;
using System.Threading.Tasks;

namespace Jupiter.Core.Services.Interfaces
{
    public interface IMessageService : IDisposable
    {

        #region Message

        Task AddMessage(Message message);
        Task UpdateMessage(Message message);

        #endregion

    }
}