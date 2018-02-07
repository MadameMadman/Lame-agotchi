using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Places.Models
{
  public class Place
  {
    private string _name;
    private string _description;
    private int _id;
    private static List<Place> _instances = new List<Place> {};

    public Place(string name, string description)
    {
      _name = name;
      _instances.Add(this);
      _id = _instances.Count;
      _description = description;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
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
    public static List<Place> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
