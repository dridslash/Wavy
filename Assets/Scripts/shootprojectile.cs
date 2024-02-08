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
        if (Input.GetKeyDown(KeyCode.B))
            Instantiate(Arrow,transform.position,transform.rotation);
    }
}
