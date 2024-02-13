using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndivitualRock : MonoBehaviour
{
//    [HideInInspector] public Rigidbody2D PipeRidgidBody;
    [HideInInspector] public GameLogic gamelogic;

    [HideInInspector] public PipeSpawner pipespawner;

    [HideInInspector] public BirdScript Birdobj;
    // Start is called before the first frame update
    void Start()
    {
        // PipeRidgidBody = GetComponent<Rigidbody2D>();
        gamelogic = GameObject.FindGameObjectWithTag("GameLogic").GetComponent<GameLogic>();
        pipespawner = GameObject.FindGameObjectWithTag("PipeSpawner").GetComponent<PipeSpawner>();
        Birdobj = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.layer == 3){
            Debug.Log("Im A Rock I hit A BIIIIIIRD!!!");
            Birdobj.BirdRidigdbody.constraints = (RigidbodyConstraints2D) RigidbodyConstraints.FreezeAll;
            gamelogic.ActiveGameOver();
            FindAnyObjectByType<AudioManager>().StopSound("Theme");
            FindAnyObjectByType<AudioManager>().PlaySound("Lose");
            pipespawner.SpawnPipes = false;
            pipespawner.Tier = 0;
            Birdobj.isgameover = true;
            Time.timeScale = 0;
        }
    }
}
