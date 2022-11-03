using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletSpeed = 10;
    public Rigidbody rb;
    public int Damage;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
   public void Fire()
    {
        rb.AddForce (transform.right * bulletSpeed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}
 