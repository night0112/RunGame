using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ChangeGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ChangeTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
