using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float interval = 5;
    MeshRenderer renderer;
    Rigidbody rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {       
        if (Time.time >= interval)
        {
            rigidbody.useGravity = true;
            renderer.enabled = true;
        }
    }
}
