using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1f;
    public float gravity = 3f;
    private Vector3 position;
    public float jumpSpeed = -10f;
    public CharacterController controller;
    // Update is called once per frame
    void Update()
    {
        position.x = speed * Input.GetAxis("Horizontal");
        if (controller.isGrounded)
        {
            position.y -= gravity;
        }
       
        controller.Move(position * Time.deltaTime);
        position.y -= gravity;
        if (Input.GetButtonDown("Jump"))
        {
            position.y = jumpSpeed;
        }
    }
}
