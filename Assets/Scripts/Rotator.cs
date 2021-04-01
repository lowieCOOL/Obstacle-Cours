using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float speed = 7.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yValue = 25 * Time.deltaTime * speed;
        //float zValue = 1 * Time.deltaTime * speed;

        transform.Rotate(0, yValue, 0);
    }
}
