using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using Yarn.Unity;

public class menu : MonoBehaviour
{
    public static bool GamePaused = false;
    public LineAdvancer lineAdvancer;

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

    void Start()
    {
        lineAdvancer = FindFirstObjectByType<LineAdvancer>();
    }

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
        Debug.Log("resume");
        lineAdvancer.gameObject.SetActive(true);
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
        Debug.Log("pause");
        lineAdvancer.gameObject.SetActive(false);
    }
}

