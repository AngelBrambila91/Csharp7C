using System;
namespace Libraries
{
    public partial class Person
    {
        public string SayHello()
        {
            return $"{Name} says Hello";
        }

        public string Greeting() => $"{Name} says Hello";
        public int Age => System.DateTime.Today.Year - DateOfBirth.Year;

        public string FavoriteIceCream { get; set; }
        private string favoriteColor;
        public string FavoriteColor
        {
            get { return favoriteColor; }
            set 
            { 
                switch(value.ToLower())
                {
                    case "red":
                    case "blue":
                    case "green":
                    favoriteColor = value;
                    break;
                    default:
                    throw new System.ArgumentException
                    ($"{value} is not a primary color." + 
                    "Choose from : red, green, blue."
                    );
                }
            }
        }

        public Person this [int index]
        {
            get
            {
                return Children[index];
            }
            set
            {
                Children[index] = value;
            }
        }

        public EventHandler Shout;
        public int AngerLevel;

        public void Poke()
        {
            AngerLevel++;
            if(AngerLevel >= 3)
            {
                if(Shout != null)
                {
                    Shout(this, EventArgs.Empty);
                    PassEvent (Shout);
                }
            }
        }

        public void PassEvent (EventHandler e)
        {

        }
    }
}