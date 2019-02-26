namespace Scripting_201910_Parcial1_base.Logic
{
    public abstract class Vehicle
    {
        protected float baseMaxSpeed;

        protected int Level { get; set; }

        protected abstract VehicleType Type { get; }

        protected Part CurrentPart { get; set; }

        public float MaxSpeed
        {
            get
            {
                return 0F;
            }
        }

        public Vehicle()
        {
          
        }

        public Vehicle(float _baseMaxSpeed)
        {
            baseMaxSpeed = _baseMaxSpeed;
            Level = 0;
            CurrentPart = null;
        }

        public bool Equip(Part part)
        {
            bool result = false;

            if (Type == part.Type || part.Type == VehicleType.Any)
            {
                result = true;
                baseMaxSpeed = baseMaxSpeed * part.SpeedBonus;

            }

            return result;
        }

        public void Upgrade()
        {
            switch (Level = 1)
            {
                case 1:
                    Level = 1;
                    baseMaxSpeed = baseMaxSpeed * 1.05F;
                    break;

                case 2:
                    Level = 2;
                    baseMaxSpeed = baseMaxSpeed * 1.10F;
                    break;

                case 3:
                    Level = 3;
                    baseMaxSpeed = baseMaxSpeed * 1.15F;
                    break;

            }
           
        }
    }
}