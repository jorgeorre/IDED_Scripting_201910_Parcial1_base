namespace Scripting_201910_Parcial1_base.Logic
{
    public class Muffler : Part
    {
        public Muffler() : base()
        {
        }

        public Muffler(float speedBonus) : base(speedBonus)
        {
            speedBonus = speedBonus*1.2F;
        }

        public override VehicleType Type
        {
            get
            {
                return VehicleType.Bike;
            }
        }
    }
}