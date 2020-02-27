using System;

namespace Dealership.Models {

  public class Car
  {
    private string _description;
    private string _makeModel;
    private int _price;
    private int _miles;

    public Car(string description, string makeModel, int price, int miles)
    {
      _description = description;
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }
    public bool WorthBuying(int maxPrice, int miles)
    {
      if((_price < maxPrice) && (_miles < miles)) {
        return true;
      } else {
        return false;
      }
    }

    public getDescription() {
      return _description;
    }

    public setDescription(string description) {
      _description = description;
    }
    public getMakeModel() {
      return _makeModel;
    }
    public setMakeModel(string makeModel) {
      _makeModel = makeModel;
    }
    public getPrice() {
      return _price;
    }
    public setPrice(int price) {
      _price = price;
    }
    public getMiles() {
      return _miles;
    }
    public setMiles(int miles) {
      _miles = miles;
    }
  }
}
