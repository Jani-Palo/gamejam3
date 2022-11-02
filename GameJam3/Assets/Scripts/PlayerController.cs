using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float JumpForce = 10f;
    float HorizontalInput;
    private Rigidbody PlayerRb;
    public bool IsOnground = true;


    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        HorizontalInput = Input.GetAxis("Horizontal");
       

        transform.Translate(Vector3.right *-1  * HorizontalInput * speed * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.Space) && IsOnground)
        {

            PlayerRb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            IsOnground = false;
        }
        else
        {
            PlayerRb.AddForce(transform.up * -JumpForce);
        }


    }
   
    private void OnCollisionEnter(Collision collision)
    {
        IsOnground = true;
    }
}
