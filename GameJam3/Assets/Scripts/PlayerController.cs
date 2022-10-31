using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController characterController;
    private Vector3 direction;
    public float speed = 10;
    public float jumpForce = 10;
    public float gravity = -20f;
    public Transform groundCheck;
    public LayerMask ground;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        direction.x = horizontalInput * speed;
        bool isGrounded = Physics.CheckSphere(groundCheck.position,0.15f,ground);
        direction.y += gravity * Time.deltaTime;
        if (isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                direction.y = jumpForce;
            }
        }
        
        characterController.Move(direction * Time.deltaTime);
    }
}
