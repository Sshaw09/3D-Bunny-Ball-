using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstructions : MonoBehaviour
{
    public string gameInstructions = "Move the player using WASD/Arrow Keys";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameInstructions);
    }

}
