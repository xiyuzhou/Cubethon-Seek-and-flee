using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public static bool status = false;

    public Material[] materials;
    public Renderer rend;


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Wall")
        {
            rend.sharedMaterial = materials[0];
            collisionInfo.collider.GetComponent<Renderer>().material = materials[0];
            status = true;
            movement.enabled = false;
            FindObjectOfType<GameManager1>().EndGame();
        }
    }
}
