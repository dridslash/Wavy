using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public  GameObject [] PipeArr;
    [HideInInspector] public float PipeDelay = 5;
    [HideInInspector] public float timer = 0;

    [HideInInspector] public float SpawnOffset = 6f;

    [HideInInspector] public bool SpawnPipes = true;
    // Start is called before the first frame update
    void Start()
    {
        PipeArr = new GameObject[2];
        SpawnPipe(true);
        SpawnPipes = true;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnPipe(false);
        
    }

    public void SpawnPipe(bool firstime){
        float lowestSpawnPoint = transform.position.y - SpawnOffset;
        float HeighestSpawnPoint = transform.position.y + SpawnOffset;

        if (SpawnPipes){

            if (firstime){
            Instantiate(PipeArr[0],transform.position,transform.rotation);
            }
            else{
                if (timer < PipeDelay){
                    timer += Time.deltaTime;
                }else{
                        Instantiate(PipeArr[0],new Vector3(transform.position.x,Random.Range(-3.63f,HeighestSpawnPoint),0),transform.rotation);
                    timer = 0;
                }
            }
            
        }
    }
}
