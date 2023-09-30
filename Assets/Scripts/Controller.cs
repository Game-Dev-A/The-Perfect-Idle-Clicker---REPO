using System;
using UnityEngine;
using TMPro;
using BreakInfinity;

public class Controller : MonoBehaviour
{
    [SerializeField] private TMP_Text points;
    [SerializeField] private TMP_Text pointsPower;

    public Data data;
    public UpgradeManager upgradeManager;

    public BigDouble ClickPower() => 1 + data.clickUpgradeLevel;

    // Start is called before the first frame update
    void Start()
    {
        data = new Data();
        upgradeManager.StartUpgradeManager();
    }

    // Update is called once per frame
    void Update()
    {
        points.text = data.points + " Points";
        pointsPower.text = "+" + ClickPower() + " Points";
    }


    public void OnClick()
    {
        data.points += ClickPower();
    }
}
