using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    //UI elements
    public Button compButton1, comptButton2, compButton3;
    
    //gameObjects
    public GameObject startPanel, securityPanel;
    public GameObject computerTerminal;

    //refs
    public DialogueController dc;

    // Start is called before the first frame update
    void Start()
    {
        startPanel.SetActive(true);
        securityPanel.SetActive(false);
        computerTerminal.SetActive(false);
        //dc = GetComponent<DialogueController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClicked(){
        startPanel.SetActive(false);
        computerTerminal.SetActive(true);
        dc.listNumber++; 
        dc.timerRunning = true;
    }

    public void SecurityClicked(){
        
    }

}
