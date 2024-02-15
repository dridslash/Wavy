using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript : MonoBehaviour
{
    [HideInInspector] public float RockMovementSpeed;
    [HideInInspector] public float ScreenEdge = -25.77f;

    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * RockMovementSpeed) * Time.deltaTime;
        if (transform.position.x < ScreenEdge)
            Destroy(gameObject);
        
    }

    public void SetMovementSpeed(float speed){
        RockMovementSpeed = speed;
    }
}
