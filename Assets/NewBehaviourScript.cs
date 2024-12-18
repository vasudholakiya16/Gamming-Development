using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int max;
        int min;

        int guess;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartGame();
        

      
        
    }

    void StartGame(){

        max = 1000;
        min = 1;
        guess = 500;

           Debug.Log("Welcome to Number Wizard!");
        // print("Welcome to Number Wizard.....!");
        Debug.Log("Pick a number in your head, but don't tell me!");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);

        Debug.Log("Tell me if your number is higher or lower than  500");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        Debug.Log("Is your number higher or lower than " + guess);  

        max = max + 1;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
            min = guess;
            NextGuess();
            // guess = (max + min) / 2;
            // Debug.Log("Is it higher or lower than..." + guess);

        }

       else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.");
            max = guess;    
            NextGuess();
            // guess = (max + min) / 2;
            // Debug.Log("Is it higher or lower than..." + guess);
        }
        // player presses Enter key
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            // Debug.Log("Enter key was pressed.");
            Debug.Log("I am a genius!");
            StartGame(); 
        }
        
        
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Higher or lower than..." + guess);
    }
}
