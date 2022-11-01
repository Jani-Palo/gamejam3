using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HealthMonitor : MonoBehaviour
{
    public static int healthPoint = 300;
    public int internalHealth;
    public GameObject healthDisplay;
    public GameObject healthBar;
    // Update is called once per frame
    void Update()
    {
        internalHealth = healthPoint;
        //healthDisplay.GetComponent<Text>().text = " " + healthPoint;
        healthBar.GetComponent<RectTransform>().sizeDelta = new Vector2(healthPoint, 30);
        if(healthPoint <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
