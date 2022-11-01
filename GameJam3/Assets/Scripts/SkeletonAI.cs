using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class SkeletonAI : MonoBehaviour
{
    public GameObject skeleton;

    private void OnTriggerEnter(Collider other)
    {
        skeleton.GetComponent<Animator>().Play("Attack");
        skeleton.GetComponent<NavigationAI>().enabled = false;
        skeleton.GetComponent<NavMeshAgent>().enabled = false;
    }
    private void OnTriggerExit(Collider other)
    {
        skeleton.GetComponent<Animator>().Play("Walk");
        skeleton.GetComponent<NavigationAI>().enabled = true;
        skeleton.GetComponent<NavMeshAgent>().enabled = true;
    }
}
