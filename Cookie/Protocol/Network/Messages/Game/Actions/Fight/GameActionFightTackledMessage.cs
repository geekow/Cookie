//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Actions.Fight
{
    using Cookie.Protocol.Network.Messages.Game.Actions;
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class GameActionFightTackledMessage : AbstractGameActionMessage
    {
        
        public new const uint ProtocolId = 1004;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        public GameActionFightTackledMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
        }
    }
}