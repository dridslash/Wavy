using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosingPipeScript : MonoBehaviour
{

    private float speed = 5f;
    public GameObject upperpipe;

    private bool GateClosed = false;

    private float first_position = 0f;
    
    public Rigidbody2D GateRigidbody;

    [HideInInspector] public bool GateFrozed = false;
    
    // Start is called before the first frame update
    void Start()
    {
        first_position = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(!GateClosed && GateFrozed == false)
            transform.position = Vector3.MoveTowards(transform.position,upperpipe.transform.position, speed * Time.deltaTime);
        else if (GateClosed == true && GateFrozed == false){
                transform.position = Vector3.MoveTowards(transform.position,new Vector3(transform.position.x,first_position,transform.position.z)
                    , speed * Time.deltaTime);
            if (transform.position.y == first_position)
                GateClosed = false;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag.Equals("Gate")){
            GateClosed = true;
        }

        if (other.gameObject.tag.Equals("Arrow")){
            Debug.Log("Arrow Hit me !!!");
            GateRigidbody.constraints = RigidbodyConstraints2D.FreezePositionY;
            GateFrozed = true;
        }
    }
}
