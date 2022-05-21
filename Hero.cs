namespace will
{
    public abstract class Hero
    {
        public Hero(String HeroName, String HeroType, int HeroLevel,
        int HeroHP, int HeroHPMax, int HeroMP, int HeroMPMax)
        {
            this.HeroName = HeroName;
            this.HeroType = HeroType;
            this.HeroLevel = HeroLevel;
            this.HeroHP = HeroHP;
            this.HeroHPMax = HeroHPMax;
            this.HeroMP = HeroMP;
            this.HeroMPMax = HeroMPMax;
        }

        public Hero()
        {

        }


        public string HeroName;
        public string HeroType;
        public int HeroLevel;
        public int HeroHP;
        public int HeroHPMax;
        public int HeroMP;
        public int HeroMPMax;


        public override string ToString()
        {
            return "Nome:" + this.HeroName + " Class:" + this.HeroType + " LvL:" + this.HeroLevel + " HP:"
            + this.HeroHP + "/" + this.HeroHPMax + " MP:" + HeroMP + "/" + HeroMPMax;
        }

        public virtual string Attack()
        {
            return this.HeroName;
        }
    }
}