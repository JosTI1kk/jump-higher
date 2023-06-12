using UnityEngine;
using UnityEngine.SceneManagement;

public class rip : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void Restart()
    {
        SceneManager.LoadScene("MainGame");
    }
}
