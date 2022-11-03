using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dwa4 : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject Spawn;
    public AudioSource audioSource;
    public AudioClip beam;
    public float speed = .5f;

    public float fireRate = 0.8f;
    private float nextFire = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        turning();
        if (Input.GetKeyDown(KeyCode.Mouse0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            shoot();

        }
    }
 
    void turning()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector2 direc = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);

        transform.right = direc;
    }

    void shoot()
    {
        GameObject projectile = (GameObject)Instantiate(Bullet, Spawn.transform);
        projectile.transform.parent = null;
        projectile.GetComponent<BulletScript>().Fire();
        audioSource.PlayOneShot(beam);
    }
}
