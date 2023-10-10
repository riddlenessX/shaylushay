using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class TriggerRiddleOne : MonoBehaviour
{
    public GameObject NewGameObject;

    
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("oNE");
    }
    
}
