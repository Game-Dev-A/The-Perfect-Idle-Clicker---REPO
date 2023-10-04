using System.Collections;
using System.Collections.Generic;
using BreakInfinity;

public class Data
{
    public BigDouble points;  //I set the points variable 
    public List<BigDouble> clickUpgradeLevel;  //I create a list with the lvl of the upgrades

    public Data()
    {
        points = 0f;  //I set the value of points to 0

        clickUpgradeLevel = Methods.CreateList<BigDouble>(3);  //I set the number of upgradeClick
    }
}
