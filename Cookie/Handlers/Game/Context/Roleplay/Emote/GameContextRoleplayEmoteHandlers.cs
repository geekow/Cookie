﻿using Cookie.API.Network;
using Cookie.Core;
using Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Emote;

namespace Cookie.Handlers.Game.Context.Roleplay.Emote
{
    public class GameContextRoleplayEmoteHandlers
    {
        [MessageHandler(EmoteListMessage.ProtocolId)]
        private void EmoteListMessageHandler(DofusClient client, EmoteListMessage message)
        {
            //
        }
    }
}