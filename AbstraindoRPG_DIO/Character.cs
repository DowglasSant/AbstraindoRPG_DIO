namespace AbstraindoRPG_DIO
{
    public class Character
    {
        public string Name { get; set; }
        public int Level {get; set; }
        public string Description { get; set; }
        public string Class {get; set; }

        public Character() { }

        public Character(string name, int level, string heroClass, string description)
        {
            this.Name = name;
            this.Level = level; 
            this.Description = description;
            this.Class = heroClass;
        }

        public virtual string Attack() 
        {
            return $"{this.Name} atacou na porrada!";
        }

        public virtual string Attack(int bonus)
        {
            return $"{this.Name} atacou na porrada com {bonus} de bônus!";
        }

        public override string ToString()
        {
            return $"Nome: {this.Name} | Level: {this.Level} | Classe: {this.Class} | Descrição: {this.Description}";
        }
    }
}
