using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldLimitScript : MonoBehaviour
{

    [HideInInspector] public GameLogic gamelogic;

    // Start is called before the first frame update
    void Start()
    {
        gamelogic = GameObject.FindGameObjectWithTag("GameLogic").GetComponent<GameLogic>();
    }

    // // Update is called once per frame
    // void Update()
    // {   
    // }


    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.layer == 3){
            gamelogic.ActiveGameOver();
            FindAnyObjectByType<AudioManager>().StopSound("Theme");
            FindAnyObjectByType<AudioManager>().PlaySound("Lose");
            Time.timeScale = 0;
        }
    }
}
