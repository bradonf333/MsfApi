namespace MsfTeamBuilderAPI.Models
{
  public class Ability
  {
    private AbilityType _type;
    public AbilityType Type
    {
      get => _type;
      set
      {
        _type = value; 
        MaxLevel = value == AbilityType.Ultimate ? 5 : 7;
      }
    }
    public string Name { get; set; }
    private int _level;
    public int Level
    {
      get { return _level;}
      set
      {
        if (value > MaxLevel)
        {
          _level = MaxLevel;
        }
      }
    }
    public string Description { get; set; }
    public int MaxLevel { get; private set;}
  }

  public enum AbilityType
  {
    Basic,
    Special,
    Ultimate,
    Passive
  }
}
