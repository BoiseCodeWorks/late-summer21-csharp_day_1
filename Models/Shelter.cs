using System.Collections.Generic;

namespace csharp_day_1.Models
{
  public class Shelter
  {
    public List<Cat> Cats { get; private set; } = new List<Cat>();
    public List<Dog> Dogs { get; private set; }

    public void AddPet(Cat cat)
    {
      Cats.Add(cat);
    }
    // Method overloading allows the use of the same method name with a different parameter signature
    public void AddPet(Dog dog)
    {
      Dogs.Add(dog);
    }

    public string Adopt(Dog d)
    {
      Dogs.Remove(d);
      return "Have fun with " + d.Name;
    }

    public string Adopt(Cat c)
    {
      Cats.Remove(c);
      return "Good luck with " + c.Name;
    }

    public Shelter()
    {
      Dogs = new List<Dog>();
    }

  }
}