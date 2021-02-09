using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject{
    [SerializeField] string storyTitle;
    [TextArea(10, 14)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;


    public string GetStoryTitle() {
        return storyTitle;
    }

    public string GetStateStory(){
        return storyText;
    }

    public State[] GetNextStates(){
        return nextStates;
    }
}
