using BreakInfinity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    //public Controller controller;  //I call the Controller script
    public Upgrade clickUpgrade;   //I call the Upgrade script

    public string clickUpgradeName;  //I set the upgrade name
    
    public BigDouble clickUpgradeBaseCost;  //I set the base cost of the upgrade
    public BigDouble clickUpgradeCostMult;  //I set the multiply of cost

    public static UpgradeManager instance;

    private void Awake() => instance = this;  //This method will start before the Start() method; I set the instance for the Controller script

    public void StartUpgradeManager()
    {
        clickUpgradeName = "Points per click"; //I change the upgrade's name
        clickUpgradeBaseCost = 10;  //I set the value of the base cost
        clickUpgradeCostMult = 1.5;  //I set the value of the multiply cost
        UpdateUpgradeUI();  //I call the UpdateUpgradeUI method
    }

    public void UpdateUpgradeUI()
    {
        var data = Controller.instance.data;
        clickUpgrade.lvlText.text = "Lvl. " + data.clickUpgradeLevel.ToString();  //I set the lvl text
        clickUpgrade.costText.text = "Cost per Point: " + Cost().ToString("F2");  //I set the cost text
        clickUpgrade.nameText.text = "+ 1 " + clickUpgradeName;  //I set the name text
    }

    public BigDouble Cost() => clickUpgradeBaseCost * BigDouble.Pow(clickUpgradeCostMult, Controller.instance.data.clickUpgradeLevel);  //I modify the cost

    public void BuyUpgrade()
    {
        var data = Controller.instance.data;
        if (data.points >= Cost())  //Check if I have more points than the cost
        {
            data.points -= Cost(); //Then I subtract the cost from the points
            data.clickUpgradeLevel += 1;  //At least I change by 1 the upgrade's level
        }
        UpdateUpgradeUI();  //I call the UpdateUpgradeUI method
    }
}
