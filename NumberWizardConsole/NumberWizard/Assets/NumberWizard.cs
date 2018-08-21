using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    private int max = 1000;
    private int min = 1;
    private int guess = 0;
    private bool init = false;
    private KeyCode keyPressed;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Think a number between 1000 to 1.....Press Space");
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!init)
            {
                CalculateGuess();
                init = true;
            }

            Debug.Log(string.Format("Is your number: {0}", guess));
            Debug.Log("Press Up arrow if is greatest otherwise press Down arrow");

        }
        else if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            min = guess;
            CalculateGuess();
            Debug.Log(string.Format("Is your number: {0}", guess));
            Debug.Log("Press Up arrow if is greatest otherwise press Down arrow");

        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            max = guess;
            CalculateGuess();
            Debug.Log(string.Format("Is your number: {0}", guess));
            Debug.Log("Press Up arrow if is greatest otherwise press Down arrow");
            KeyCode.
        }
        else
        {
        }


    }

    private void CalculateGuess()
    {
        guess = (max + min) / 2;
    }
}
