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
      Parcel newParcel = new Parcel();
      Assert.AreEqual(typeof(Parcel), newParcel.GetType());
    }
  }
}