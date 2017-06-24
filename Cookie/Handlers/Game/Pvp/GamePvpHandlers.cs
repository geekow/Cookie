﻿using Cookie.API.Network;
using Cookie.Core;
using Cookie.API.Protocol.Network.Messages.Game.Pvp;

namespace Cookie.Handlers.Game.Pvp
{
    public class GamePvpHandlers
    {
        [MessageHandler(AlignmentRankUpdateMessage.ProtocolId)]
        private void AlignmentRankUpdateMessageHandler(DofusClient client, AlignmentRankUpdateMessage message)
        {
            //
        }

        [MessageHandler(UpdateMapPlayersAgressableStatusMessage.ProtocolId)]
        private void UpdateMapPlayersAgressableStatusMessageHandler(DofusClient client,
            UpdateMapPlayersAgressableStatusMessage message)
        {
            //
        }
    }
}