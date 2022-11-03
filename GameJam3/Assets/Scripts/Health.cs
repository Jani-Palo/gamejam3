using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int MaxHealth = 10;
    private int CurrentHealth;
    public bool IsDead = false;
    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = 10;
        IsDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (MaxHealth <= 0)
        {
            Destroy(this.gameObject);
            IsDead = true;
        }
        else
        {
            IsDead = false;
        }
        
    }
    private void OnCollisionEnter(Collision other)
    {
        {
            if (other.gameObject.tag == "Bullet")
            {
                MaxHealth -= 2;
                

            }
        }
    }
}
