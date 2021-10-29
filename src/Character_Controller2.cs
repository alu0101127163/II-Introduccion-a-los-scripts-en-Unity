using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller2 : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    public float playerSpeed = 400.0f;
    private float gravityValue = -9.81f;
    public int points = 0;

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {

        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(0,0,0); 

        if (Input.GetKey("i"))
        {
          move += new Vector3(0, 0,1);
        }

         if (Input.GetKey("k"))
        {
          move += new Vector3(0, 0,-1);
        }

         if (Input.GetKey("j"))
        {
          move += new Vector3(-1, 0,0);
        }
         if (Input.GetKey("l"))
        {
          move += new Vector3(1, 0,0);
        }

        controller.Move(move * Time.deltaTime * playerSpeed);

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
}
