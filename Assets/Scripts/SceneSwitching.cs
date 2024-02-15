using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitching : MonoBehaviour
{


    void Start(){
        Time.timeScale = 1;
    }

    public void SwitchScene(){
        SceneManager.LoadScene("GameLoop");
        FindAnyObjectByType<AudioManager>().PlaySound("ButtonClick");
    }

    public void SwitchToMenu(){
        SceneManager.LoadScene("HomeMenu");
        FindAnyObjectByType<AudioManager>().PlaySound("Theme");
        FindAnyObjectByType<AudioManager>().PlaySound("ButtonClick");
    }

    public void QuitGame(){
        Application.Quit();
        FindAnyObjectByType<AudioManager>().PlaySound("ButtonClick");
        Debug.Log("Quiting");
    }
}
