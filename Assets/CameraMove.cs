using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform ballPos;
    private Vector3 _start_pos = new Vector3(0, 2.45f, -17.35f);
    private Vector3 _start_rot = new Vector3(-4.1f, 0, 0);
    private bool _onPos;
    //private Vector3 distt = new Vector3();
    private Rigidbody camBody;

    void Start()
    {
        _onPos = false;
        camBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_onPos)
        {
            transform.position = Vector3.MoveTowards(transform.position, _start_pos, 20 * Time.deltaTime);
            transform.LookAt(ballPos);
            if (transform.position == _start_pos)
            {
                _onPos = true;
                ballPos.GetComponent<moving>().camera_onPos = true;
                //moving.camera_onPos = true; 
            }
        }
        else
        {
            transform.LookAt(ballPos);
            //Vector3 distt = new Vector3(0, 0, 10);
            if (ballPos.position.z - transform.position.z >= 10)
            {
                // distt.Set(transform.position.x, transform.position.y, ballPos.position.z - 10);
                //transform.position = distt;
                camBody.velocity = 10 * Vector3.forward;
            }
        }
    }
}
