using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Animator>().Play("Idle");
        if(Input.GetKey(KeyCode.D))
        {
            this.GetComponent<Animator>().Play("Walk");

        }
        else
        {
            this.GetComponent<Animator>().Play("Idle");
        }
        
    }
}
