using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AdventureGame : MonoBehaviour{
    [SerializeField] TextMeshProUGUI storyTitleComponent;
    [SerializeField] TextMeshProUGUI storyTextComponent;
    [SerializeField] State startingState;
    

    State state;
    // Start is called before the first frame update
    void Start(){
        state = startingState;
        printStory();
    }

    // Update is called once per frame
    void Update(){
        ManageState();
    }

    private void ManageState(){
        var nextStates = state.GetNextStates();
        //the foor loop checks how big the array 'nextStates' is
        //and matches it to the possible answers.
        for(int index = 0; index < nextStates.Length; index++){
            if (Input.GetKeyDown(KeyCode.Alpha1 + index)) {
                state = nextStates[index];
                printStory();
            }
        }
        // let's us quit the game at any given moment
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
            Debug.Log("Escape is pressed");
        }
        /*
        if (Input.GetKeyDown(KeyCode.Alpha1)){
            state = nextStates[0];
            printStory();
        } else if (Input.GetKeyDown(KeyCode.Alpha2)){
            state = nextStates[1];
            printStory();
        }
        */
    }

    private void printStory(){
        storyTitleComponent.text = state.GetStoryTitle();
        storyTextComponent.text = state.GetStateStory();
    }
}
