using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitHandler : MonoBehaviour
{
    public void ReturnToMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
