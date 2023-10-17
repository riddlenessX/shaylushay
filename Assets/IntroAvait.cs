using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroAvait : MonoBehaviour
{
    public int WaitTime;
    void Start()
    {
        StartCoroutine(WaitForLevel());

    }
    IEnumerator WaitForLevel()
    {
        yield return new WaitForSeconds(WaitTime);
        SceneManager.LoadScene(1);
    }
}
