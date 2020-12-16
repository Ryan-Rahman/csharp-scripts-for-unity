//simple timed game for 290 seconds, customizable
using UnityEngine;
using UintyEngine.UI;

public class GameTimer : MonoBehaviour {
    //how much time is left
    public float timeLeft = 290f;
    //text that will display timer
    public Text startText;

    //update method starts timer
    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = (timeLeft).ToString("0");
        if (timeLeft < 0)
        {
      
}
