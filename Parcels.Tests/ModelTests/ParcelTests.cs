using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcels.Models;

namespace Parcels.Tests
{
  [TestClass]
  public class ParcelTests
  { 
    [TestMethod]
    public void ParcelConstructor_CreateAnInstanceOfParcel_Parcel()
    {
      Parcel newParcel = new Parcel(2,2,2,2);
      Assert.AreEqual(typeof(Parcel), newParcel.GetType());
    }
    [TestMethod]
    public void ParcelConstructor_ReturnsParcelDimensions_Int()
    {
      int testParcelLength = 5;
      Parcel newParcel = new Parcel(testParcelLength,7,3,4);
      int confirmParcelLength = 5;
      Assert.AreEqual(confirmParcelLength, newParcel.Length);

    }
    [TestMethod]
    public void ParcelConstructor_ReturnsVolumeOfParcel_Volume()
    {
      Parcel newTestParcel = new Parcel(5, 7, 10, 0);
      int confirmVolume = 350;
      Assert.AreEqual(confirmVolume, newTestParcel.Volume());
    }
    [TestMethod]
    public void ParcelConstructor_ReturnsCostOfShippingBasedOnVolumeDividedBy32_Int()
    {
      Parcel newTestParcel = new Parcel(5, 7, 10, 0);
      double testCost = 10.94;
      double volume = newTestParcel.Volume();
      Assert.AreEqual(testCost, newTestParcel.CostToShip(volume));
    }
  }
}