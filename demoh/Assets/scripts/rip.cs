using UnityEngine;
using UnityEngine.SceneManagement;

public class rip : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("scenes");
    }

    public void Restart()
    {
        SceneManager.LoadScene("scenes");
    }
}
