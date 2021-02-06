using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicManager : MonoBehaviour
{
    //Adding all the input and output slots
    public GameObject and_in1;
    public GameObject and_in2;
    public GameObject and_out;
    public GameObject or_in1;
    public GameObject or_in2;
    public GameObject or_out;
    public GameObject nand_in1;
    public GameObject nand_in2;
    public GameObject nand_out;
    public GameObject nor_in1;
    public GameObject nor_in2;
    public GameObject nor_out;
    public GameObject xor_in1;
    public GameObject xor_in2;
    public GameObject xor_out;
    public GameObject not_in1;
    public GameObject not_out;

    public void calc_logic()
    {
        and_out.GetComponentInChildren<output>().val = and_func();
        nand_out.GetComponentInChildren<output>().val = nand_func();
        nor_out.GetComponentInChildren<output>().val = nor_func();
        or_out.GetComponentInChildren<output>().val = or_func();
        xor_out.GetComponentInChildren<output>().val = xor_func();
        not_out.GetComponentInChildren<output>().val = not_func();
    }

    public int bton(bool a)
    {
        if(a == true)
        {
            return 1;
        }
        return 0;
    }
    public bool ntob(int a)
    {
        if (a == 1)
        {
            return true;
        }
        return false;
    }

    public bool and_func()
    {
        return ntob(bton(and_in1.GetComponentInChildren<input>().val) & bton(and_in2.GetComponentInChildren<input>().val));
    }
    public bool nand_func()
    {
        return ntob(~(bton(nand_in1.GetComponentInChildren<input>().val) & bton(nand_in2.GetComponentInChildren<input>().val)));
    }

    public bool or_func()
    {
        return ntob(bton(or_in1.GetComponentInChildren<input>().val) | bton(or_in2.GetComponentInChildren<input>().val));
    }

    public bool nor_func()
    {
        return ntob(~(bton(nor_in1.GetComponentInChildren<input>().val) | bton(nor_in2.GetComponentInChildren<input>().val)));
    }
    public bool xor_func()
    {
        return ntob(bton(xor_in1.GetComponentInChildren<input>().val) ^ bton(xor_in2.GetComponentInChildren<input>().val));
    }

    public bool not_func()
    {
        return ntob(~(bton(not_in1.GetComponentInChildren<input>().val)));
    }
}
