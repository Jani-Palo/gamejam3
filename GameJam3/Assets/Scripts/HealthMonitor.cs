using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthMonitor : MonoBehaviour
{
    public static int healthPoint = 100;
    public int internalHealth;
    public GameObject healthDisplay;
    // Update is called once per frame
    void Update()
    {
        internalHealth = healthPoint;
        healthDisplay.GetComponent<Text>().text = " " + healthPoint;
    }
}
