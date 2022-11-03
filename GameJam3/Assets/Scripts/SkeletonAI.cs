using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class SkeletonAI : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip slash;
    public AudioClip Walk;
    public GameObject skeleton;
    public bool isAttacking = false;
    public GameObject Player;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
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
        if(Player.gameObject)
        skeleton.GetComponent<Animator>().Play("Walk");
        audioSource.PlayOneShot(Walk);
        skeleton.GetComponent<NavigationAI>().enabled = true;
        skeleton.GetComponent<NavMeshAgent>().enabled = true;
        StopCoroutine(TakeHealth());
        this.GetComponent<MeshCollider>().enabled = true;
        isAttacking=false;

    }

    IEnumerator TakeHealth()
    {
        yield return new WaitForSeconds(1.1f);
        audioSource.PlayOneShot(slash);
        HealthMonitor.healthPoint -= 50;
        yield return new WaitForSeconds(1f);
        isAttacking = false;
        skeleton.GetComponent<Animator>().Play("Walk");
        skeleton.GetComponent<NavigationAI>().enabled = true;
        skeleton.GetComponent<NavMeshAgent>().enabled = true;
        this.GetComponent<MeshCollider>().enabled = true;
    }
}
