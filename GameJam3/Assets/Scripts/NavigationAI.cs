using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NavigationAI : MonoBehaviour
{
    public GameObject destination;
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(destination.transform.position);
    }
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("ASD");
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
        }
    }
}
