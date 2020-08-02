using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerController controller;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            // controller.enabled = false;
            Debug.Log("We hit an obstacle!");
        }
    }
}
