namespace csharp_day_1.Models
{
  public class Dog
  {
    public string Name { get; set; }
    public bool IsHappy { get; set; }

    public string Feed()
    {
      IsHappy = true;
      return "woof";
    }

    public Dog(string name, bool isHappy = true)
    {
      Name = name;
      IsHappy = isHappy;
    }
  }
}