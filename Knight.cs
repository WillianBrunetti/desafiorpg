namespace will
{
    public class Knight : Hero
    {
        public Knight(String HeroName, String HeroType, int HeroLevel,
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
            return this.HeroName + " " + "Atacou com a espada";
        }

        public string Attack(int Bonus)
        {
            if(Bonus < 4){
            return this.HeroName + " " + "Atacou fraco com a espada com bonus de ataque de +" + Bonus;
            }
            else if(Bonus >= 4 && Bonus <= 7){
                return this.HeroName + " " + "Atacou efetivamente com a espada com bonus de ataque de +" + Bonus;
            }
            else{
                return this.HeroName + " " + "Atacou Muito efetivamente com a espada com bonus de ataque de +" + Bonus;
            }
        }

        public string Attack(string Miss)
        {
            return this.HeroName + " " + "Errou a magia";
        }
    }
}