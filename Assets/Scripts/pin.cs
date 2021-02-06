using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pin : MonoBehaviour
{
    public GameObject pin_pair;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Output")
        {  
            pin_pair.GetComponent<wire_render>().val = other.gameObject.GetComponentInChildren<output>().val;
            Debug.Log("output detected");
        }
        if (other.tag == "Power High")
        {
            pin_pair.GetComponent<wire_render>().val = other.gameObject.GetComponentInChildren<power_high>().val;
            Debug.Log("output detected");
        }
        if (other.tag == "Power Low")
        {
            pin_pair.GetComponent<wire_render>().val = other.gameObject.GetComponentInChildren<power_low>().val;
            Debug.Log("output detected");
        }
        if (other.tag == "Input")
        {
            other.gameObject.GetComponentInChildren<input>().val = pin_pair.GetComponent<wire_render>().val;
            GameObject.Find("LogicManager").GetComponentInChildren<logicManager>().calc_logic();
            Debug.Log("input detected");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Output" || other.tag == "Power High")
        {
            pin_pair.GetComponent<wire_render>().val = false;
            GameObject.Find("LogicManager").GetComponentInChildren<logicManager>().calc_logic();
        }
        
        if(other.tag == "Input")
        {
            other.gameObject.GetComponentInChildren<input>().val = false;
            GameObject.Find("LogicManager").GetComponentInChildren<logicManager>().calc_logic();
        }
    }
    
}
