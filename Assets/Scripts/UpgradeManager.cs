using BreakInfinity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public Controller controller;
    public Upgrade clickUpgrade;

    public string clickUpgradeName;
    
    public BigDouble clickUpgradeBaseCost;
    public BigDouble clickUpgradeCostMult;

    public void StartUpgradeManager()
    {
        clickUpgradeName = "Upgrade";
        clickUpgradeBaseCost = 10;
        clickUpgradeCostMult = 1.5;
        UpdateUpgradeUI();
    }

    public void UpdateUpgradeUI()
    {
        clickUpgrade.lvlText.text = "Lvl. " + controller.data.clickUpgradeLevel.ToString();
        clickUpgrade.costText.text = "Cost per Point: " + Cost().ToString("F2");
        clickUpgrade.nameText.text = clickUpgradeName;
    }

    public BigDouble Cost() => clickUpgradeBaseCost * BigDouble.Pow(clickUpgradeCostMult, controller.data.clickUpgradeLevel);

    public void BuyUpgrade()
    {
        if(controller.data.points >= Cost())
        {
            controller.data.points -= Cost();
            controller.data.clickUpgradeLevel += 1;
        }
        UpdateUpgradeUI();
    }
}
