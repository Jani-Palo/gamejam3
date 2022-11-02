using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float JumpForce = 9.81f;
    float HorizontalInput;
    private Rigidbody PlayerRb;
    public bool IsOnground = true;

    public Animator animator;
    public Transform model;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");

        animator.SetFloat("speed", Mathf.Abs(HorizontalInput));

        transform.Translate(Vector3.right *-1  * HorizontalInput * speed * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.Space) && IsOnground)
        {

            PlayerRb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            IsOnground = false;
        }
        else
        {
            PlayerRb.AddForce(transform.up* - JumpForce);
        }
        if(HorizontalInput != 0)
        {
            Quaternion newRotation = Quaternion.LookRotation(new Vector3(HorizontalInput, 0, 0));
            model.rotation = newRotation;
        }
        animator.SetBool("isGrounded", IsOnground);
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        IsOnground = true;
    }
}
