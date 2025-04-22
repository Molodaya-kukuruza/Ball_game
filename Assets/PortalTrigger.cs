using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball")
        {
            GetComponent<AudioSource>().Play();
            Color myCol = GetComponent<Renderer>().material.color;
            Debug.Log(myCol.ToString());
            other.gameObject.GetComponent<Renderer>().material.color = myCol;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GetComponent<AudioSource>().Pause();
    }
}
