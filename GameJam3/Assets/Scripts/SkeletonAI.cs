using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class SkeletonAI : MonoBehaviour
{
    public GameObject skeleton;
    public bool isAttacking = false;
    private void OnTriggerEnter(Collider other)
    {
        if (isAttacking == false)
        {
            isAttacking = true;
            this.GetComponent<MeshCollider>().enabled = false;
            skeleton.GetComponent<Animator>().Play("Attack");
            skeleton.GetComponent<NavigationAI>().enabled = false;
            skeleton.GetComponent<NavMeshAgent>().enabled = false;
            StartCoroutine(TakeHealth());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        skeleton.GetComponent<Animator>().Play("Walk");
        skeleton.GetComponent<NavigationAI>().enabled = true;
        skeleton.GetComponent<NavMeshAgent>().enabled = true;
        StopCoroutine(TakeHealth());
        this.GetComponent<MeshCollider>().enabled = true;
        isAttacking=false;
    }

    IEnumerator TakeHealth()
    {
        yield return new WaitForSeconds(2.2f);
        HealthMonitor.healthPoint -= 10;
        isAttacking = false;
        skeleton.GetComponent<Animator>().Play("Walk");
        skeleton.GetComponent<NavigationAI>().enabled = true;
        skeleton.GetComponent<NavMeshAgent>().enabled = true;
        this.GetComponent<MeshCollider>().enabled = true;
    }
}
