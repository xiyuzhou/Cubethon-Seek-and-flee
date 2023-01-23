using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;

    void Update()
    {   
        if (PlayerCollision.status == false)
        {
            scoreText.text = player.position.z.ToString("0");
        }
    }

}
