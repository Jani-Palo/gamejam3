using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NavigationAI : MonoBehaviour
{
    public Transform destination;
    public float speed = 3f;
    //NavMeshAgent agent;
    void Start()
    {
        destination = GameObject.FindGameObjectWithTag("Player").transform;
        //agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (destination.position.x > transform.position.x)
        {
            transform.Translate(-transform.right * speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0,90,0);
        }
        else
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        //agent.SetDestination(destination.transform.position);
    }
   
}
