using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static bool ready = false;
    void Start() {
        ready = false;
    }
    void Update()
    {   
        if (SceneManager.GetActiveScene().name == "PlayScene") {
            if (Input.GetMouseButtonDown(0))
                ready = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
            GoStartScene();
        else {
            if (SceneManager.GetActiveScene().name == "StartScene") {
                if (Input.GetKeyDown(KeyCode.Escape)) 
                    Application.Quit();     
            }
        }
    }
    public static void GoPlayScene() {
        ready = false;
        SceneManager.LoadScene("PlayScene");
    }
    public static void GoStartScene() {
        SceneManager.LoadScene("StartScene");
    }
    public static void GoGameOverScene() {
        SceneManager.LoadScene("GameOverScene");
    }
    public static void StopTime() {
        Time.timeScale = 0;
        Time.fixedDeltaTime = 0.02F * Time.timeScale;
    }
    public static void GoTime() {
        Time.timeScale = 1;
        Time.fixedDeltaTime = 0.02F * Time.timeScale;
    }
}
