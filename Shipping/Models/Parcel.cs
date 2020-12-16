using System.Collections.Generic;

namespace Shipping.Models
{
  public class Parcel
  {
    //fields
    private double _Heigth {get; set;}
    private double _Length {get; set;}
    private double _Width {get; set;}
    private double _Weight {get; set;}

    
    //constructor
    public Parcel(double heigth, double length, double width, double weight)
    {
      _Heigth = heigth;
      _Length = length;
      _Width = width;
      _Weight = weight;
    }

    public static double Volume(double heigth, double length, double width)
    {
      return heigth*length*width;
    }

    // public static double CostToShip()
    // {

    // }
  }
}