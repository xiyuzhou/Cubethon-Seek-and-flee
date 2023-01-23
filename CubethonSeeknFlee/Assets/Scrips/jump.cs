using UnityEngine;
using UnityEngine.SceneManagement;

public class jump : MonoBehaviour
{
    public void OnButtonPress()
    {
        SceneManager.LoadScene(0);
    }
    public void PressExit()
    {
        Application.OpenURL("about:blank");
    }
    public void OnButtonPress2()
    {
        SceneManager.LoadScene(1);
    }
}