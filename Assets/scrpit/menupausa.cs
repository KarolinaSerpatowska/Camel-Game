using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menupausa : MonoBehaviour {

    public void Stop()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void Continue()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void End()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
