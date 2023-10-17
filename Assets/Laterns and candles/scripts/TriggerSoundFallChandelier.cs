using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSoundFallChandelier : MonoBehaviour
{
    public GameObject Sound;
    public GameObject Chandelier;
    private void Start()
    {
        Sound.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        Sound.SetActive(true);
       
        
    }
}
