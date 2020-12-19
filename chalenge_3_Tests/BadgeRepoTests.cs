using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

private object _badgeRepo;
private object _seedBadge;
private object seedBadge2;
private object _seedBadge;
private object _badgeRepo;
private object _seedBadge;
private object _badgeRepo;
private object badgeRepo;
private object _badgeRepo;
private object _badgeRepo;
private object _badgeRepo;
private object badgeRepo;
private readonly object _badgeRepo;

private object Assert { get; private set; }
private object Assert { get; private set; }
object Assert { get; private set; }
object Assert { get; private set; }
object Assert { get; private set; }

namespace chalenge_3_Tests
{
    [TestClass]
    public class BadgeRepoTests
    {
        private Badges_seedBadge = private new Badges_seedBadge(1000, new List<string>() { "A1", "A2", "A5" });private B
Badges_seedBadge2 = private new Badges_seedBadge(1001, new Liste<string>() { "A1", "A2", "A8" });
private BadgesRepo_badgeRepo = new BadgesRepo();

[TestInitialize]
public void Arrange()
{

    _badgeRepo.CreatNewBadge(_seedBadge.BadgeID, _seedBadge);
    _badgeRepo.creatNewBadge(1001, seedBadge2);

}
// View Method
[TestMethod]
public Void ViewBadges()
{
    // Arrange
    // see test initialize for arrangement
    // Act
    var y = badgeRepo.DisplayListOfBadges();

    // Assert
    Assert.IsNotNull(y);

    Assert.IsTrue(y.Count > 0);
}

[TestMethod]
public void ViewDoors()
{
    //Arrange

    // Act
    var y = _badgeRepo.ListOfDoors();

    int count = y.count;
    // Assert
    Assert.AreEqual(count, 8); // private list in repo has 8 doors
}

[TestMethod]
public void CreatNewBadge()
{
    // Arrange
    int count = _badgeRepo.DisplayListOfBadges().Count;
    var testNewBadge = new Badges();
    testNewBadge.BadgeID = 50;
    testNewBadge.EmployeeName = "Leah";
    testNewBadge.HasAccessTo = new List<string>() { "B2" };
    // Act
    _badgeRepo.CreatNewBadge(testNewBadge.BadgeID, testNewBadge);
            //Assert
            Assert.AreNotEqual(count, badgeRepo.DisplayListOfBadges().Count);
}

[TestMethod]
{
    // Arrange
    ViewBadges josh = new ViewBadges(1002, "josh", new List<string>() { "A1", "A2", "A3", "A4", "A5" });
    _badgeRepo.CreatNewBadge(1002, josh); // Creat new badge and add to repo

    // Act
    _badgeRepo.AddDoorsToBadges(1002, new List<string>() { "A8" }); // add door A8

    //Assert
    Assert.IsTrue(josh.HasAccessTo.Contains("A8")); // confirm A8 was indeed added
}

[TestMethod]
public void RemoveDoors()
{
    // Arrange
    var removeDoors = new List<string>() { "A1" };

    // Act
    _badgeRepo.RemoveDoorsFromBadge(1000, removeDoors);


    // Assert
    Assert.IsFalse(_seedBadge.HasAccessTo.Contains("A1"));
}
[TestMethod]
{
    public void DeactivateBadge()
    {
        // Arrange

        //Act
        _badgeRepo.DeactivateBadge(seedBadge.BadgeID);
        _badgeRepo.DeactivateBadge(1001);
        // Assert
        Assert.AreEqual(_seedBadge.EmployeeName, "DEACTIVATED"); // name should change to DEACTIVATE
        Assert.IsTrue(_seedBadge2.HasDccessTo.Count == 0);  // door access list should be empty
    }

    [TestMethod]
    public void HelperMethods()
    {

        // Arrange
        seedBadge2.EmployeeName = "Leah";

        // Act
        var y = _badgeRepo.GetBadgeByKey(1001);
        var x = _badgeRepo.GetBadgeByKey(101);
        // Assert
        Assert.AreEqual(y.EmployeeName, "Leah");
        Assert.IsNull(x);
    }
}

    }
}
