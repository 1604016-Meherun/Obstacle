using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropper : MonoBehaviour
{
   [SerializeReference] float timeToWait = 5f;
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
        if(Time.time > timeToWait)
        {

            renderer = GetComponent<MeshRenderer>();
            rigidbody = GetComponent<Rigidbody>();
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
