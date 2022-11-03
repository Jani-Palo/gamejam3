using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level3Load : MonoBehaviour
{
    public SceneManager sceneManager;
    // Start is called before the first frame update
    void Start()
    {
        sceneManager = GetComponent<SceneManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(4);
        }    
    }
}
