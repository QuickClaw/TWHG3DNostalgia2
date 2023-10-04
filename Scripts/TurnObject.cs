using UnityEngine;

public class TurnObject : MonoBehaviour
{
    public float turnSpeed;

    void Update()
    {
        transform.Rotate(0f, turnSpeed * Time.deltaTime, 0f);
    }
}
