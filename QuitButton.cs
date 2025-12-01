using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    //public GameObject pauseMenu;
    //public Button button; 

    // Start is called before the first frame update
    //void Awake()
    //{
        //button = GetComponent<Button>();
        //button.onClick.AddListener(Quit);
    //}

    
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quitting game..");
    }
}
