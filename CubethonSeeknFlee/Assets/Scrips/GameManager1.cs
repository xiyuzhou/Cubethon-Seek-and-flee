using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager1 : MonoBehaviour
{
    bool gameHasEnded = false;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    

    public void EndGame()
    {
        if (gameHasEnded == false) {
            gameHasEnded = true;
            Debug.Log("GameOver");
            Invoke("Restart", 2f);
        }
    }

    void Restart()
    {
        PlayerCollision.status = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
