using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootprojectale : MonoBehaviour
{

    public GameObject Arrow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)){
            FindAnyObjectByType<AudioManager>().PlaySound("arrowshot");
            Instantiate(Arrow,new Vector3(transform.position.x + 2f,transform.position.y - 0.5f, transform.position.z),transform.rotation);
        }
    }
}
