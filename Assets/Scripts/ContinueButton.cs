using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    public string nextLevelName;

    public void OnButtonClick()
    {
        SceneManager.LoadScene(nextLevelName);
    }
}
