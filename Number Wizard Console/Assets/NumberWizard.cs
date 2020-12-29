using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int maxGuess = 1000;
    int minGuess = 1;
    int guess = 500;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Please pick a number!");
        Debug.Log("The highest number can be: " + maxGuess);
        Debug.Log("The lowest number can be: " + minGuess);
        Debug.Log("Tell me if your number is higher or lower than ");
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct!");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
            minGuess = guess;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.");
            maxGuess = guess;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key was pressed.");
        }
    }
}
