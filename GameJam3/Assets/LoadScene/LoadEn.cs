using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadEn : MonoBehaviour
{
    public SceneManager scene;
    // Start is called before the first frame update
    void Start()
    {
        scene = GetComponent<SceneManager>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(5);
        }
    }
}
