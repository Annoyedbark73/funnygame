using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void QuitGame()
    {
        string reason = "Quit using a quit button";

        Debug.Log(reason);

        Application.Quit();
        /* this will quit the application and tell you how it was quit... 
         pretty important i guess. mainly for me in this instance using a button
        at least i hope so... */
        
    }


    public void PlayGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("started");

        bool Lctrl = Input.GetKey(KeyCode.LeftControl);
        bool enter = Input.GetKey(KeyCode.Return);
        //windows secret
        if (Lctrl && enter)
        {
            print("Party time");
            SceneManager.LoadScene(32);
        }

        //holding both of these keys wether on windows or mac will pt you in a secret room
        bool lcommand = Input.GetKey(KeyCode.LeftCommand);
            bool Alt = Input.GetKey(KeyCode.LeftAlt);
        //mac secret 
        if (lcommand && enter)
        {
            print("e");
            SceneManager.LoadScene(31);
        }

    }
    private void Update()
    {
        bool Lctrl = Input.GetKey(KeyCode.LeftControl);
        bool enter = Input.GetKey(KeyCode.Return);
        //windows secret
        if (Lctrl && enter)
        {
            print("Party time");
            SceneManager.LoadScene(32);
        }

        //holding both of these keys wether on windows or mac will pt you in a secret room
        bool lcommand = Input.GetKey(KeyCode.LeftCommand);
        bool Alt = Input.GetKey(KeyCode.LeftAlt);
        //mac secret 
        if (lcommand && enter)
        {
            print("e");
            SceneManager.LoadScene(31);
        }

    }








































































    //subscribe to coolness https://www.youtube.com/channel/UCRAUjrHRGbg4WNqMBTR-RNQ/videos
}
