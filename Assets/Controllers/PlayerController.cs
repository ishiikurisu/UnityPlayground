using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float playerSpeed = 50;

    void Start()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            rigidBody.AddForce(-playerSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            rigidBody.AddForce(playerSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rigidBody.AddForce(0, 0, playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rigidBody.AddForce(0, 0, -playerSpeed * Time.deltaTime);
        }
    }
}
