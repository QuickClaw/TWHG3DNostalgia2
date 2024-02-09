using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private Vector3 movement;

    public Rigidbody rb;

    void Update()
    {
        //float leftRight = Input.GetAxisRaw("Horizontal");
        //float forwardBackward = Input.GetAxisRaw("Vertical");

        //Vector3 movement = speed * Time.deltaTime * new Vector3(leftRight, 0.0f, forwardBackward);

        //transform.Translate(movement, Space.Self);

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement.Normalize();

        rb.velocity = movement * speed;

        #region Slow 
        if (Input.GetKey(KeyCode.LeftControl))
        {
            speed = 2;
        }

        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            speed = 4.2f;
        }
        #endregion
    }
}
