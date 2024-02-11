using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameLogic : MonoBehaviour
{

    //  public Text Score;

     public TMP_Text ScoreMeshed;

     public TMP_Text LatestScore;
    [HideInInspector] public int score = 0;
    
    public GameObject GameOverManager;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        GameOverManager.SetActive(false);
        LatestScore.text = "Highest Score : " + GetLatestScore().ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    public void AddScore(){
        ++score;
        // Score.text = score.ToString();
        ScoreMeshed.text = score.ToString();
        SetLatestScore(score);
    }

    public void GameOver(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        FindAnyObjectByType<AudioManager>().PlaySound("Theme");
        FindAnyObjectByType<AudioManager>().PlaySound("ButtonClick");
    }

    [ContextMenu("Testing Active Game Over")]
    public void ActiveGameOver(){
        GameOverManager.SetActive(true);
    }

    public void SetLatestScore(int score){
        PlayerPrefs.SetInt("sc",score);
    }

    public int GetLatestScore(){
        return PlayerPrefs.GetInt("sc");
    }
}
