using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int collisionCount = 0;
    private void OnCollisionEnter(Collision collision)
    {
        collisionCount++;
        Debug.Log("You've bumped into the wall " + collisionCount + " times.");
    }
}
