using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager1 gameManager;

    void OnTriggerEnter()
    {
        Debug.Log("aaaaaaaaaa");
        if (PlayerCollision.status == false) {
            gameManager.CompleteLevel(); 
        }
        
    }

}
