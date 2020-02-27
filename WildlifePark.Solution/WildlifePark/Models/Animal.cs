using System;

namespace WildlifePark.Models {

  public class Animal {

    private string _name;
    private string _type;
    private int _age;

    public Animal(string name, string type, int age) {
      _name = name;
      _type = type;
      _age = age;
    }

    public string getName() {
      return _name;
    }

    public void setName(string name) {
      _name = name;
    }

    public string getType() {
      return _type;
    }

    public void setType(string type) {
      _type = type;
    }

    public int getAge() {
      return _age;
    }

    public void setAge(int age) {
      _age = age;
    }
  }
}