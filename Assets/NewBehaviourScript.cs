using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int max = 1000;
        int min = 1;
         Debug.Log("Welcome to Number Wizard!");
        // print("Welcome to Number Wizard.....!");
        Debug.Log("Pick a number in your head, but don't tell me!");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);

        Debug.Log("Tell me if your number is higher or lower than  500");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
        }

       else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.");
        }
        // player presses Enter key
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key was pressed.");
        }
        
        
    }
}
