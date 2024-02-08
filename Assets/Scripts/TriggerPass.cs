using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPass : MonoBehaviour
{

    public GameLogic gamelogic;
    // Start is called before the first frame update
    void Start()
    {
         gamelogic = GameObject.FindGameObjectWithTag("GameLogic").GetComponent<GameLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        gamelogic.AddScore();
    }
}
