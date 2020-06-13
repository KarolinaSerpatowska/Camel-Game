using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    static Animator anim;
    private CharacterController controller;
    public float speed=5.0f;
    public float rotationspeed = 75.0f;
    public float jumpSpeed = 2.0F;
    public float gravity =3.0f;
    private Vector3 moveDirection = Vector3.zero;

    void Start ()
    {
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();

    }
	
	
	void Update ()
    {
       
        float translation = Input.GetAxis("Vertical") * speed;
            float rotation = Input.GetAxis("Horizontal") * rotationspeed;
            translation *= Time.deltaTime;
            rotation *= Time.deltaTime;
 
            transform.Translate(0, 0, translation);
            transform.Rotate(0, rotation, 0);
        if (controller.isGrounded)
        {
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);


        if (translation != 0)
            {
                anim.SetBool("IsRunning", true);
            }
            else
            {
                anim.SetBool("IsRunning", false);
            }
        
    }
}
