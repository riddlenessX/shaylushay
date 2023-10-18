using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOpenDoor : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator Door;
    private void OnTriggerEnter(Collider other)
    {
        Door.Play("Door_Open");
    }
}
