namespace Scripting_201910_Parcial1_base.Logic
{
    public class Nitro : Part
    {
        public Nitro() : base()
        {
        }

        public Nitro(float speedBonus) : base(speedBonus)
        {
            speedBonus = speedBonus * 1.4F;
        }

        public override VehicleType Type
        {
            get
            {
                return VehicleType.Car;
            }
        }
    }
}