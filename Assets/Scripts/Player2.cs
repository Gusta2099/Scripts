using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{

    CharacterController controller;

    Vector3 forward;
    Vector3 strafe;
    Vector3 vertical;

    public float forwardSpeed = 5f;
    public float strafeSpeed = 3f;

    float gravity;
    float jumpSpeed;
    float maxJumpHeight = 0.5f;
    float timeToMaxHeight = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

        controller = GetComponent<CharacterController>();

        gravity = (-5 * maxJumpHeight) / (timeToMaxHeight * timeToMaxHeight);
        jumpSpeed = (3 * maxJumpHeight) / (timeToMaxHeight * timeToMaxHeight);


    }

    // Update is called once per frame
    void Update()
    {

        float forwardInput = Input.GetAxisRaw("Vertical2");
        float strafeInput = Input.GetAxisRaw("Horizontal2");

        forward = forwardInput * forwardSpeed * transform.forward;
        strafe = strafeInput * strafeSpeed * transform.right;

        vertical += gravity * Time.deltaTime * Vector3.up;

        if(controller.isGrounded)
        {
            vertical = Vector3.down;
        }

        if(Input.GetKeyDown(KeyCode.RightControl) && controller.isGrounded)
        {
            vertical = jumpSpeed * Vector3.up;
        }

        Vector3 finalVelocity = forward + strafe + vertical;

        controller.Move(finalVelocity * Time.deltaTime);
    }
}
