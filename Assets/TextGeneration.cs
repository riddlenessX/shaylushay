using Invector.vCharacterController;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TextGeneration: MonoBehaviour
{
    public string[] lines;
    public float speedText;
    public Text dialogueText;
    public int index;

    public GameObject vBasicController_Shaylushay;
    private vThirdPersonInput scriptOnShaylushay;

    public GameObject Canvas;
    private Canvas CanvasOncameraForImage;

    private void Awake()
    {
        // Получаем скрипт с объекта vBasicController_Shaylushay
        scriptOnShaylushay = vBasicController_Shaylushay.GetComponent<vThirdPersonInput>();

        // Получаем компонент с объекта Canvas
        CanvasOncameraForImage = Canvas.GetComponent<Canvas>();
        DisablePlayerScript();


    }
    private void Start()
    {
        dialogueText.text = string.Empty;
        
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
        gameObject.SetActive(false);
        
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray()){
            dialogueText.text += c;
            yield return new WaitForSeconds(speedText);
        }
    }

    public void SkipText()
    {
        if(dialogueText.text == lines[index])
        {
            NextLines();
        }
        else
        {
            StopAllCoroutines();
            dialogueText.text = lines[index];
            
        }
    }

    private void NextLines()
    {
        if(index < lines.Length - 1)
        {
            index++;
            dialogueText.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
            dialogueText.gameObject.SetActive(false);
            EnablePlayerScript();
            DisableCanvasComponent();
        }
    }

    public void DisablePlayerScript()
    {
        // Отключаем скрипт на объекте vBasicController_Shaylushay
        scriptOnShaylushay.enabled = false;
    }

    public void EnablePlayerScript()
    {
        // Включаем скрипт на объекте vBasicController_Shaylushay
        scriptOnShaylushay.enabled = true;
        
    }


 
    public void DisableCanvasComponent()
    {
        //отключаем картинку
        CanvasOncameraForImage.enabled = false;
    }


}