//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Context.Roleplay.TreasureHunt
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.Protocol;
    using Cookie.IO;

    public class PortalUseRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6492;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_portalId;
        
        public virtual uint PortalId
        {
            get
            {
                return m_portalId;
            }
            set
            {
                m_portalId = value;
            }
        }
        
        public PortalUseRequestMessage(uint portalId)
        {
            m_portalId = portalId;
        }
        
        public PortalUseRequestMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarInt((int)m_portalId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_portalId = reader.ReadVarUhInt();
        }
    }
}