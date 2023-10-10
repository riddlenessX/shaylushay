using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRiddleTwo : MonoBehaviour
{
    public GameObject NewGameObject;

    private void OnTriggerEnter(Collider other)
    {
        
        Debug.Log("Two");
      
    }
}
