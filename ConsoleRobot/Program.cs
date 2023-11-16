

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
        
        robotName = "test";
        studentNames = new string[] { "Reece", "Test" };
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
        health = 10 * constitution;
    }

    public string GetAllStats()
    {

        return ($"Current Health: {health}, Attack: { attack}, Defense: { defense}, Speed: { speed}");

    }


}


