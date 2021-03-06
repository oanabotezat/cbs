/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2017-2018 The International Federation of Red Cross and Red Crescent Societies. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using Dolittle.Events;

namespace Events.AutomaticReplyMessages
{
    public class MessageUpdated : IEvent
    {
        
        public MessageUpdated(Guid id, string message) 
        {
            this.Id = id;
            this.Message = message;
               
        }
        public Guid Id { get; }
        public string Message { get; }
    }
}