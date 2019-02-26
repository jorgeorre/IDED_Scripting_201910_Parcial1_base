namespace Scripting_201910_Parcial1_base.Logic
{
    public class Bike : Vehicle
    {
        public Bike() : base()
        {
            if (CurrentPart is Muffler || CurrentPart is Turbo)
            {
                Equip(CurrentPart);
            }
        }

        public Bike(float _baseMaxSpeed) : base(_baseMaxSpeed)
        {
        }

        protected override VehicleType Type
        {
            get
            {
                return VehicleType.Bike;
            }
        }
    }
}