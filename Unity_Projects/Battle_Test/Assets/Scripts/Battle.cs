using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : Monster
{
    public CharacterController controller;
    public Transform cam;
    public Interactable focus;
    public Vector3 playerVelocity;
    public float playerSpeed = 6f;
    public float sprint = 2f;
    public float height = 2f;
    private float gravityValue = -9.8f;
    private bool groundedPlayer;
    

    // Update is called once per frame
    private void Start()
    {
        
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0.1)
        {
            playerVelocity.y = 0;
        }

        float horizontal = Input.GetAxisRaw("Horizontal");
        Vector2 direction = new Vector3(horizontal, 0f).normalized;
        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg + cam.eulerAngles.y;
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

            Vector2 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * playerSpeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.LeftShift))
                controller.Move(moveDir.normalized * playerSpeed * Time.deltaTime * sprint);
        }

        if (Input.GetButtonDown("Jump") && playerVelocity.y < 0.3 && playerVelocity.y > -0.3)
        {
            playerVelocity.y += Mathf.Sqrt(height * -3.0f * gravityValue);
        }
        playerVelocity.y += gravityValue * Time.deltaTime * sprint;
        controller.Move(playerVelocity * Time.deltaTime);


    }

    


}
