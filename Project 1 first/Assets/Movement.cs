using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1f;
    public float gravity = 3f;
    private Vector3 position;
    public float jumpSpeed = -10f;
    public CharacterController controller;
    private int jumpCount;
    public int jumpCountMax = 2;
    

    // Update is called once per frame
    void Update()
    {
        position.x = speed * Input.GetAxis("Horizontal");
        position.y -= gravity;
        if (controller.isGrounded)
        {
            position.y = 0;
            jumpCount = 0;
        }
        if (controller.isGrounded)
        {
            position.y -= gravity;
        }

        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
             position.y = jumpSpeed;
             jumpCount++;
        }
        controller.Move(position * Time.deltaTime);
      
       
    }
}
