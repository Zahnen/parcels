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
  }
}


