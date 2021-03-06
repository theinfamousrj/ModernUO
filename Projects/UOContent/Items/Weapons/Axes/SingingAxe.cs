namespace Server.Items
{
    public class SingingAxe : OrnateAxe
    {
        [Constructible]
        public SingingAxe()
        {
            SkillBonuses.SetValues(0, SkillName.Musicianship, 5);
        }

        public SingingAxe(Serial serial) : base(serial)
        {
        }

        public override int LabelNumber => 1073546; // singing axe

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);

            var version = reader.ReadEncodedInt();
        }
    }
}
