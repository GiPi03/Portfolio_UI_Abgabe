using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dropdown : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI text2;
 
    public bool english;
    public bool german;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void ChangeScreens()
    {
        if(text.text == "English")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
        else if (text.text == "German")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        else if(text.text == "Deutsch")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        else if(text.text == "Englisch")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
    }
    
}