namespace NingGame
{

    public class Dog
    {
        public int health = 5;
        public int maxHealth = 10;
        public string Name;
        public string Color;
        public bool LikeJump;
        public bool Gender;
        public bool Hungry;
        public int Age;
        public float Energy;

        public float CorrentHealthPercent()
        {
            return (health / (float)maxHealth) * 100;
        }
        public virtual void RestoreHealth()
        {
            health = maxHealth;
        }
        public Dog(string _Name, string _Color, bool _LikeJump, bool _Gender, int _Age)
        {
            Name = _Name;
            Color = _Color;
            LikeJump = _LikeJump;
            Gender = _Gender;
            Age = _Age;
            Hungry = true;
            Energy = 10;
            health = 5;
        }

        public string Getname() { return Name; }
        public string GetColor() { return Color; }
        public virtual int GetAge() { return Age; }



        public void Eating()
        {
            Hungry = false;
            Energy = +1;
            health = +1;
        }

        public void Playing()
        {
            Hungry = true;
            Energy = -1;
            health = +1;
        }
    }
}
