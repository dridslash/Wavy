using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [HideInInspector] public float PipeMovementSpeed;
    [HideInInspector] public float ScreenEdge = -25.77f;

    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * PipeMovementSpeed) * Time.deltaTime;
        if (transform.position.x < ScreenEdge)
            Destroy(gameObject);
        
    }

    public void SetMovementSpeed(float speed){
        PipeMovementSpeed = speed;
    }
}
