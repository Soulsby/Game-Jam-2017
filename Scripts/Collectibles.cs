using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{

    public int quantity
    {
        get;
        set;
    }
    public int maxquantity;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void add()
    {
        quantity += 1;
    }

    public void add(int toAdd)
    {
        quantity += 5;
    }
}
