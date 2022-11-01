using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonAI : MonoBehaviour
{
    public GameObject skeleton;

    private void OnTriggerEnter(Collider other)
    {
        skeleton.GetComponent<Animator>().Play("Attack");
    }
    private void OnTriggerExit(Collider other)
    {
        skeleton.GetComponent<Animator>().Play("Idle");
    }
}
