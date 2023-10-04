using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    void Update()
    {
        float leftRight = Input.GetAxisRaw("Horizontal");
        float forwardBackward = Input.GetAxisRaw("Vertical");

        Vector3 movement = speed * Time.deltaTime * new Vector3(leftRight, 0.0f, forwardBackward);

        transform.Translate(movement, Space.Self);

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
