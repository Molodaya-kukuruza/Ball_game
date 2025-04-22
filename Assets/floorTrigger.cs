using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name != "Ball")
        {
            collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().Play();
    }
}
