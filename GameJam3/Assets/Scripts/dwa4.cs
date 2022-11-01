using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dwa4 : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject Spawn;
    public float speed = .5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        turning();
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            shoot();
             
        }
    }
    void turning()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 100;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector2 direc = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);

        transform.right = direc;
    }

    void shoot()
    {

        GameObject projectile = (GameObject)Instantiate(Bullet, Spawn.transform.position, Quaternion.identity);
        projectile.transform.right = transform.right;
    }
}
