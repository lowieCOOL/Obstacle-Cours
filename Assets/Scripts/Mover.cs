using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed = 7.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    // Is called a set amount of times per second, by default 100Hz
    void FixedUpdate()
    {
        
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(xValue, 0, zValue);
    }
}
