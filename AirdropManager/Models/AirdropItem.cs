using System.Xml.Serialization;

namespace RestoreMonarchy.AirdropManager.Models
{
    public class AirdropItem
    {
        public AirdropItem() { }
        public AirdropItem(ushort itemId, int chance)
        {
            ItemId = itemId;
            Chance = chance;
        }
        [XmlAttribute("ItemId")]
        public ushort ItemId { get; set; }
        [XmlAttribute("Chance")]
        public int Chance { get; set; }
    }
}
