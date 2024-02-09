using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

     public Rigidbody2D BirdRidigdbody;

     public GameObject BirdWing;

     public Animator WingAnimator;

     [HideInInspector] public float flightFroce = 10.00f;

     [HideInInspector] public bool isgameover = false;

     [HideInInspector] public GameLogic gamelogic;

     [HideInInspector] public PipeSpawner pipespawner;
    // Start is called before the first frame update
    void Start()
    {
        gamelogic = GameObject.FindGameObjectWithTag("GameLogic").GetComponent<GameLogic>();
        pipespawner = GameObject.FindGameObjectWithTag("PipeSpawner").GetComponent<PipeSpawner>();
        isgameover = false;
    }

    // Update is called once per frame
    void Update()
    {
       BirdMovement();
    }

    public void BirdMovement(){
         if (Input.GetKeyDown(KeyCode.Space) && !isgameover){
            BirdRidigdbody.velocity = Vector2.up * flightFroce;
            BirdRidigdbody.rotation += 20;
            WingAnimator.SetBool("Flaped",true);
        }
        if (BirdRidigdbody.rotation > 0)
            BirdRidigdbody.rotation --;

        if (BirdRidigdbody.rotation <= 0)
            WingAnimator.SetBool("Flaped",false);
    }
    
}
