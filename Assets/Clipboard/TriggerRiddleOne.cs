using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class TriggerRiddleOne : MonoBehaviour
{
    public GameObject dialogBox;
    public GameObject Sounds;
    private bool isInRange;
    private bool SoundAccess = true;
    void OnTriggerEnter(Collider other)
    {
        if(SoundAccess)
        {
            Sounds.SetActive(true);
            SoundAccess = false;    
        }
        isInRange = true;
        dialogBox.SetActive(true);
        
    }

    void OnTriggerExit(Collider other)
    {
       
        isInRange = false;
        dialogBox.SetActive(false);
        
    }

    
}
