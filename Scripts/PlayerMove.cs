using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController controller;
    public float Force;
    public float gravity = -9.81f;
    public Vector3 right;
    public Vector3 left;
    public Vector3 gravVelocity;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    public float jumpHeight = 3f;
    
    void Start()
    {
        right = new Vector3(Force, 0, 0);
        left = new Vector3(-Force, 0, 0);
    }

    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            controller.Move(right);
        }
        if (Input.GetKey("a"))
        {
            controller.Move(left);
        }
    }
    private void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && gravVelocity.y < 0)
        {
            gravVelocity.y = -2f;
        }
        if (Input.GetKeyDown("space") && isGrounded)
        {
            gravVelocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        gravVelocity.y += gravity * Time.deltaTime;
        controller.Move(gravVelocity * Time.deltaTime);
    }
}
