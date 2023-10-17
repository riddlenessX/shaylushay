using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsChandelier : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody PhysicsPrefab;
    
    void OnTriggerEnter(Collider other)
    {
        PhysicsPrefab.GetComponent<Light>().enabled = false;
        PhysicsPrefab.isKinematic = false;
    }
}
