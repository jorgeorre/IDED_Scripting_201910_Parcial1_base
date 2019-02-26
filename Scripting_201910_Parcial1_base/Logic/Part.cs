namespace Scripting_201910_Parcial1_base.Logic
{
    public abstract class Part
    {
        protected float speedBonus;
        protected float durability;

        public int Level { get; protected set; }
        public abstract VehicleType Type { get; }

        public float SpeedBonus
        {
            get { return 0F; }
            protected set { speedBonus = value; }
        }

        public float Durability
        {
            get { return 0F; }
            protected set { durability = value; }
        }

        public Part()
        {
        }

        public Part(float speedBonus)
        {
            switch (Durability)
            {
                case 1:
                    durability = 1;
                    speedBonus = speedBonus * 1F;
                    break;
                case 2:
                    durability = 0.8F;
                    speedBonus = speedBonus * 0.8F;
                    break;
                case 3:
                    durability = 0.6F;
                    speedBonus = speedBonus * 0.6F;
                    break;
                case 4:
                    durability = 0.4F;
                    speedBonus = speedBonus * 0.4F;
                    break;
                case 5:
                    durability = 0.2F;
                    speedBonus = speedBonus * 0.2F;
                    break;
                case 6:
                    durability = 0F;
                    speedBonus = speedBonus * 0;
                    break;

            }
        }

        public void Upgrade()
        {
            switch (Level = 1)
            {
                case 1:
                    Level = 1;
                    speedBonus = speedBonus * 1.03F;
                    break;

                case 2:
                    Level = 2;
                    speedBonus = speedBonus * 1.06F;
                    break;
                case 3:
                    Level = 3;
                    speedBonus = speedBonus * 1.09F;
                    break;
            }
        }
    }
}