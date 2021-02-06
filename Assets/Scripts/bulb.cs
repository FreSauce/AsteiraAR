using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulb : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Output" && other.GetComponentInChildren<output>().val == true)
        {

            Behaviour halo = (Behaviour)GetComponent("Halo");

            halo.enabled = true;
        }
        else
        {
            Behaviour halo = (Behaviour)GetComponent("Halo");
            halo.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Output")
        {
            Behaviour halo = (Behaviour)GetComponent("Halo");

            halo.enabled = false;
        }
    }
}
