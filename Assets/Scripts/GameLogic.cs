using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameLogic : MonoBehaviour
{

     public Text Score;

     public TMP_Text ScoreMeshed;
    [HideInInspector] public int score = 0;
    
    public GameObject GameOverManager;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        GameOverManager.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    public void AddScore(){
        ++score;
        Score.text = score.ToString();
        ScoreMeshed.text = score.ToString();
    }

    public void GameOver(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    [ContextMenu("Testing Active Game Over")]
    public void ActiveGameOver(){
        GameOverManager.SetActive(true);
    }
}
