//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Interactive
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.IO;
    
    
    public class InteractiveUsedMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5745;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_entityId;
        
        public virtual ulong EntityId
        {
            get
            {
                return m_entityId;
            }
            set
            {
                m_entityId = value;
            }
        }
        
        private uint m_elemId;
        
        public virtual uint ElemId
        {
            get
            {
                return m_elemId;
            }
            set
            {
                m_elemId = value;
            }
        }
        
        private ushort m_skillId;
        
        public virtual ushort SkillId
        {
            get
            {
                return m_skillId;
            }
            set
            {
                m_skillId = value;
            }
        }
        
        private ushort m_duration;
        
        public virtual ushort Duration
        {
            get
            {
                return m_duration;
            }
            set
            {
                m_duration = value;
            }
        }
        
        private bool m_canMove;
        
        public virtual bool CanMove
        {
            get
            {
                return m_canMove;
            }
            set
            {
                m_canMove = value;
            }
        }
        
        public InteractiveUsedMessage(ulong entityId, uint elemId, ushort skillId, ushort duration, bool canMove)
        {
            m_entityId = entityId;
            m_elemId = elemId;
            m_skillId = skillId;
            m_duration = duration;
            m_canMove = canMove;
        }
        
        public InteractiveUsedMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhLong(m_entityId);
            writer.WriteVarUhInt(m_elemId);
            writer.WriteVarUhShort(m_skillId);
            writer.WriteVarUhShort(m_duration);
            writer.WriteBoolean(m_canMove);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_entityId = reader.ReadVarUhLong();
            m_elemId = reader.ReadVarUhInt();
            m_skillId = reader.ReadVarUhShort();
            m_duration = reader.ReadVarUhShort();
            m_canMove = reader.ReadBoolean();
        }
    }
}