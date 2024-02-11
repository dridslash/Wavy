using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public  GameObject [] PipeArr;
    [HideInInspector] public float PipeDelay;
    [HideInInspector] public float timer = 0;

    [HideInInspector] public float Tier = 0;

    [HideInInspector] public float SpawnOffset = 6f;

    [HideInInspector] public bool SpawnPipes = true;

    [HideInInspector] public int Random_Spanwer = 0;
    // Start is called before the first frame update
    void Start()
    {
        PipeDelay = 5;
        SpawnPipe(true);
        SpawnPipes = true;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnPipe(false);
        
    }

    public void SpawnPipe(bool firstime){
        Set_Speed_Delay_By_Difficulty(5,2);
        if (SpawnPipes){
            if (firstime){
                Instantiate(PipeArr[0],transform.position,transform.rotation);
            }
            else{
                if (timer < PipeDelay){
                    timer += Time.deltaTime;
                }else if (timer >= PipeDelay){
                    Game_Tier();
                    timer = 0;
                }
            }
            Tier += Time.deltaTime;
        }
    }

    public void Set_Speed_Delay_By_Difficulty(float speed, float delay){
        PipeDelay = delay;
        foreach(GameObject pipe in PipeArr){
            pipe.GetComponent<PipeMovement>().SetMovementSpeed(speed);
        }
    }

    public void Game_Tier(){
        Random_Spanwer = Random.Range(0,4);
        float lowestSpawnPoint = transform.position.y - SpawnOffset;
        float HeighestSpawnPoint = transform.position.y + SpawnOffset;
        if (Tier >= 4 && Tier <= 10){
                Set_Speed_Delay_By_Difficulty(5,2);
                Instantiate(PipeArr[0],new Vector3(transform.position.x,Random.Range(-3.63f,HeighestSpawnPoint),0),transform.rotation);
            }
            else if (Tier >= 12 && Tier <= 30){
                Set_Speed_Delay_By_Difficulty(6,0);
                if (Random_Spanwer == 0)
                    Instantiate(PipeArr[0],new Vector3(transform.position.x,Random.Range(-3.63f,HeighestSpawnPoint),0),transform.rotation);
                else if (Random_Spanwer == 1)
                    Instantiate(PipeArr[2],transform.position,transform.rotation);
                else
                    Instantiate(PipeArr[0],new Vector3(transform.position.x,Random.Range(-3.63f,HeighestSpawnPoint),0),transform.rotation);
            }
            else if (Tier >= 30 && Tier <= 50){
                Instantiate(PipeArr[0],new Vector3(transform.position.x,Random.Range(-3.63f,HeighestSpawnPoint),0),transform.rotation);
            }
            else if (Tier >= 50){
                Set_Speed_Delay_By_Difficulty(7,0);
                if (Random_Spanwer == 0)
                    Instantiate(PipeArr[0],new Vector3(transform.position.x,Random.Range(-3.63f,HeighestSpawnPoint),0),transform.rotation);
                else if (Random_Spanwer == 1)
                    Instantiate(PipeArr[2],transform.position,transform.rotation);
                else if (Random_Spanwer == 2)
                    Instantiate(PipeArr[1],transform.position,transform.rotation);
                else
                    Instantiate(PipeArr[0],new Vector3(transform.position.x,Random.Range(-3.63f,HeighestSpawnPoint),0),transform.rotation);
            }
    }
    
}
