using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashSceneManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(LoadHomeScene());
    }
    IEnumerator LoadHomeScene()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }

}
