using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
  [SerializeField] float timeToWait = 3f;
    MeshRenderer meshRenderer;
    Rigidbody rb;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rb.useGravity = false;
    }

    void Update()
    {
       if(Time.time > timeToWait)
       {
        //Debug.Log("required Seconds Passed");
        meshRenderer.enabled = true;
        rb.useGravity = true;
       }
    }
}
