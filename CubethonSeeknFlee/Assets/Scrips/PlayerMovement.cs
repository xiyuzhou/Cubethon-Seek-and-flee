using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    public float playerSpeed = 1000f;
    public float SideSpeed = 500f;
    void Start()
    {
        rb.useGravity = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, playerSpeed    * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(SideSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-SideSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager1>().EndGame();
            PlayerCollision.status = true;
        }
        if (Input.GetKey("j"))
        {
            rb.transform.Rotate(0, -1, 0);
        }
        if (Input.GetKey("l"))
        {
            rb.transform.Rotate(0, 1, 0);
        }
        if (Input.GetKey("k"))
        {
            rb.transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
        }
        if (Input.GetKey("i"))
        {
            rb.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
        }
    }
}
