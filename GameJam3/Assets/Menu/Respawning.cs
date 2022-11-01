using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Respawning : MonoBehaviour
{
   
    private void Start()
    {
        HealthMonitor.healthPoint = 300;
        SceneManager.LoadScene(1);
    }
}
