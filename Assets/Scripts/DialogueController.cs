using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueController : MonoBehaviour
{
    //list
    public List<string> dialogueOptions = new List<string>(); 

    //gameObjects
    public TMP_Text dialogueText;

    //variables
    public int listNumber; 
    private float textTimer = 3.0f;
    public bool timerRunning; 

    //refs
    public ButtonController bc;

    // Start is called before the first frame update
    void Start()
    {
        dialogueText.text = dialogueOptions[listNumber];
        listNumber = 0;
        timerRunning = false;
    }

    // Update is called once per frame
    void Update()
    {
        dialogueText.text = dialogueOptions[listNumber];
        TextTimer();
    }

    void TextTimer(){
        if(timerRunning){
            if(textTimer > 0){
                textTimer -= Time.deltaTime;
            }
            else {
                textTimer = 0;
                listNumber++;
                timerRunning = false;
                bc.securityPanel.SetActive(true);
            }
        }
    }
}
