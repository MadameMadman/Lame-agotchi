using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Pets.Models
{
  public class Pet
  {
    private string _name;
    private string _description;
    private int _id;
    private static List<Pet> _instances = new List<Pet> {};
    private string _hunger;

    public Pet(string name, string description, string hunger)
    {
      _name = name;
      _instances.Add(this);
      _id = _instances.Count;
      _description = description;
      _hunger = hunger;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetHunger()
    {
      return _hunger;
    }

    public void SetHunger(string newHunger)
    {
      _hunger = newHunger;
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public int GetId()
    {
      return _id;
    }
    public static List<Pet> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Pet Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
