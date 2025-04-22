using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    public bool camera_onPos;
    private bool OnFloor = false;
    private Rigidbody ballBody;
    // Start is called before the first frame update
    void Start()
    {
        camera_onPos = false;
        ballBody = GetComponent<Rigidbody>();
        //ballBody.AddForce(0, 0, 100, ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "CubFloor") {
            OnFloor = true;
            //ballBody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY;

        }
        else
        {
            GetComponent<AudioSource>().Play();
            Vector3 dirr = (collision.gameObject.transform.position - transform.position)/
                Vector3.Distance(collision.gameObject.transform.position, transform.position);
            //Debug.Log(collision.gameObject.name);
            collision.gameObject.GetComponent<Rigidbody>().AddForce(dirr*15, ForceMode.Impulse);
        }
    }

    private void FixedUpdate()
    {
       if (OnFloor && camera_onPos)
       {
            //ballBody.AddForce(0, 0, 100, ForceMode.Force);
            ballBody.velocity = 10*Vector3.forward;
        }
    }

}
