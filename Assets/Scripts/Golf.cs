using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golf : Sphere // INHERITANCE
{
    private void Awake()
    {
        SetMass(); // ABSTRACTION
    }

    protected override void SetMass() // POLYMORPHISM
    {
        gameObject.GetComponent<Rigidbody>().mass = 5;
    }
}
