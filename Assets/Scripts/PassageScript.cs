using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassageScript : MonoBehaviour
{

    private bool openPassage;
    public GameObject PassageLimit;

    private float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        openPassage = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (openPassage)
            transform.position = Vector2.MoveTowards(transform.position,PassageLimit.transform.position,speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Arrow")){
            Debug.Log("Arrow Hit me !!!");
            openPassage = true;
        }
    }
}
