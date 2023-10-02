using System;
using UnityEngine;
using TMPro;
using BreakInfinity;
using System.Collections.Generic;

public class Controller : MonoBehaviour
{
    [SerializeField] private TMP_Text points;  //I get the points text
    [SerializeField] private TMP_Text pointsPower;  //I get the power of points text

    public Data data; //I call the Data script
    //public UpgradeManager upgradeManager; //I call the UpgradeManager script
    public static Controller instance;  //I create the instance for the Controller script

    private void Awake() => instance = this;  //This method will start before the Start() method; I set the instance for the Controller script

    public BigDouble ClickPower() => 1 + data.clickUpgradeLevel; //I set the power of a click

    // Start is called before the first frame update
    void Start()
    {
        data = new Data();  //I get the Data script
        UpgradeManager.instance.StartUpgradeManager();  //I call the StartUpgradeManager moethod of the UpgradeManager script
    }

    // Update is called once per frame
    void Update()
    {
        points.text = data.points + " Points";  //I change the text of the total points
        pointsPower.text = "+" + ClickPower() + " Points";  //I change the text of the power of points
    }


    public void OnClick()
    {
        data.points += ClickPower(); //I change the value of the points by 1 when the button is pressed
    }
}
