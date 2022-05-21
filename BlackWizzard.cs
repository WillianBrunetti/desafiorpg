namespace will
{
    public class BlackWizzard : Hero
    {
        public BlackWizzard(String HeroName, String HeroType, int HeroLevel,
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
        public override string Attack()
        {
            return this.HeroName + " " + "Lançou magia negra";
        }

        public string Attack(int Bonus)
        {
            if(Bonus < 4){
            return this.HeroName + " " + "Lançou magia negra fraca com bonus de ataque de +" + Bonus;
            }
            else if(Bonus >= 4 && Bonus <= 7){
                return this.HeroName + " " + "Lançou magia negra efetiva com bonus de ataque de +" + Bonus;
            }
            else{
                return this.HeroName + " " + "Lançou Magia negra Muito efetiva com bonus de ataque de +" + Bonus;
            }
        }

        public string Attack(string Miss)
        {
            return this.HeroName + " " + "Errou a magia";
        }
    }
}