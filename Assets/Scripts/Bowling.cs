using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowling : Sphere
{
    private void Awake()
    {
        SetMass();
    }

    protected override void SetMass()
    {
        gameObject.GetComponent<Rigidbody>().mass = 25;
    }
}
