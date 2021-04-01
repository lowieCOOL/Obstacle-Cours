using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("You bumped into the wall");
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
