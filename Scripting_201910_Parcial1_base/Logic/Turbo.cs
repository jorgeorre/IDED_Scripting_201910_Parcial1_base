namespace Scripting_201910_Parcial1_base.Logic
{
    public class Turbo : Part
    {
        public Turbo() : base()
        {
        }

        public Turbo(float speedBonus) : base(speedBonus)
        {
            speedBonus = speedBonus * 1.5F;
        }

        public override VehicleType Type
        {
            get
            {
                return VehicleType.Any;
            }
        }
    }
}