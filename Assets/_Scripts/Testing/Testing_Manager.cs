using System;
using TMPro;
using UnityEngine;

public class Testing_Manager : MonoBehaviour
{
    public TextMeshProUGUI Xvalue;
    public TextMeshProUGUI Yvalue;
    public TextMeshProUGUI Zvalue;
    
    void Update()
    {
        Xvalue.text = Math.Round(Input.acceleration.x, 3).ToString();
        Yvalue.text = Math.Round(Input.acceleration.y, 3).ToString();
        Zvalue.text = Math.Round(Input.acceleration.z, 3).ToString();
    }
}
