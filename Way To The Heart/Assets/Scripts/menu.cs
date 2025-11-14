using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class menu : MonoBehaviour
{
    public static bool GamePaused = false;

    public GameObject pauseMenuUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (GamePaused)
            {
                Resume();
                
            }
            else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
        Debug.Log("resume");

    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
        Debug.Log("pause");
    }
}

