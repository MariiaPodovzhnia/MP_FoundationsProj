
using UnityEngine;

public class MovementControler : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float jumpForce = 7f;
    public float gravity = -20f;

    private float verticalVelocity;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        move = Vector3.ClampMagnitude(move, 1f);

        if (controller.isGrounded)
        {
            verticalVelocity = -2f;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpForce;
            }
        }

        verticalVelocity += gravity * Time.deltaTime;

        Vector3 velocity = move * movementSpeed;
        velocity.y = verticalVelocity;

        controller.Move(velocity * Time.deltaTime);
    }
}
