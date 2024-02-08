using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitching : MonoBehaviour
{
    public void SwitchScene(){
        SceneManager.LoadScene("GameLoop");
    }

    public void SwitchToMenu(){
        SceneManager.LoadScene("HomeMenu");
    }
}
