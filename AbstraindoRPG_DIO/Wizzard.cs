namespace AbstraindoRPG_DIO
{
    public class Wizzard : Character
    {
        public Wizzard() 
        {}

        public Wizzard(string name, int level)
        {
            this.Name = name;
            this.Level = level;
            this.Class = "Mage";
            this.Description = "Mago comum";
        }

        public override string Attack()
        {
            return $"{this.Name} Atacou no poderzinho!";
        }

        public override string Attack(int bonus)
        {
            return $"{this.Name} atacou no poderzinho com {bonus} de bônus!";
        }
    }
}
