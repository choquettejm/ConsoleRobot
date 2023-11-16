




namespace ConsoleRobot
{


    public class ActionResult
    {
        public string ActionName { get; set; }
        public string AnimationName { get; set; }


    }

    public class YourRobot
    {
        public string robotName { get; set; }
        public string[] studentNames { get; set; }
        public double attack { get; set; }
        public double defense { get; set; }
        public double speed { get; set; }
        public double constitution { get; set; }
        public double health { get; set; }
        public string primaryColor { get; set; }
        public string secondaryColor { get; set; }


        public YourRobot()
        {

            robotName = "Smasher";
            studentNames = new string[] { "Reece", "Jason" };
            attack = 10;
            defense = 10;
            speed = 10;
            constitution = 10;
            health = 10 * constitution;
            primaryColor = "";
            secondaryColor = "";

        }


        public void Reset()
        {
            attack = default(double);
            defense = default(double);
            speed = default(double);
            constitution = default(double);
            health = GetMaxHeath();
        }

        public string GetAllStats()
        {

            return ($"Current Health: {health}, Attack: { attack}, Defense: { defense}, Speed: { speed}");

        }

        public double GetMaxHeath()
        {
            return 10 * constitution;
        }

        public double TakeDamage()
        {
            double damageDealt = 0;
            double newHealth = 0;
            double incomingDamage = 0;
            double currentHealth = health;

            damageDealt = incomingDamage - (defense / 100 * incomingDamage);
            
            return newHealth = currentHealth - damageDealt;


        }


        public static double explosiveDiahrea(double damage)
        {
            YourRobot robot = new YourRobot();

            ActionResult result = new ActionResult();

            result.ActionName = "Explosive Diahrea";
            result.AnimationName = "Punch";

            damage = .8 * robot.attack + .2 * robot.defense;

            //return damage;
            return result;
        }

        public static faceSlap()
        {

            YourRobot robot = new YourRobot();
            ActionResult result = new ActionResult();
            
            result.ActionName = "Face Slap";
            result.AnimationName = "Punch";

            double damage = .1 * robot.attack + .9 * robot.defense;
                        
            return result;
        }


        public static PerformAction()
        {
            Random random = new Random();

            // Generate a random number between 1 and 4
            int randomNumber = random.Next(1, 5);

            switch (randomNumber)
            {
                case 1:
                    explosiveDiahrea(5);
                    break;
                case 2:
                    faceSlap(5);
                    break ;
                default:
                    break;

            }
            
                     
            ActionResult performAction = new ActionResult(explosiveDiahrea(5));



            return performAction.ActionName();

        }



    }
}


