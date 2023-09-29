using System;
using UnityEngine;
using TMPro;
using BreakInfinity;

public class Controller : MonoBehaviour
{
    public TMP_Text points;

    public Data data;
    // Start is called before the first frame update
    void Start()
    {
        data = new Data();

        data.points = BigDouble.Add(data.points, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        data.points *= 100;
        points.text = "Points: " + data.points;
        Debug.Log(points);
    }
}
