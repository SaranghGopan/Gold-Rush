using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeSceneManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void LoadGamePlayScene()
    {
        SceneManager.LoadScene(2);
    }
    public void Quit()
    {
       Application.Quit();
    }
    public void HomeScene()
    {
        SceneManager.LoadScene(1);
    }
}
