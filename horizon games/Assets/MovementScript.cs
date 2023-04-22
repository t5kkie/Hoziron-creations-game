using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    private CharacterController2D player;

    public float speed = 40f;
    bool jump = false;
    bool crouch = false;
    float horiontalMove = 0f;

    // Update is called once per frame
    void Update()
    {
        horiontalMove = Input.GetAxisRaw("Horizontal") * speed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if (Input.GetButtonDown("Crouch")) {
            crouch = false;
        }
    }

    private void FixedUpdate()
    {
        player.Move(horiontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
