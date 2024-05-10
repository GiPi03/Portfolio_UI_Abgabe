using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject StartScreen;
    public GameObject MainMenu;
    public GameObject Blurred;
    public GameObject PauseMenu;
    public GameObject OptionsFromGame;
    public TextMeshProUGUI dynamicText;
    public TextMeshProUGUI PauseVolume;
    public TextMeshProUGUI timerText;
    public Slider slider;
    public Slider sliderCopy;
    public Dropdown dropdown;
    public Dropdown dropdown2;
    bool timerActive = false;
    public static GameManager instance;
    private float timer = 0.0f;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }
    }

    public void LoadScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
   
    void Start()
    {

    }

    public void SetVolume()
    {
        audioSource.volume = slider.value / 10f;
        dynamicText.text = slider.value.ToString();
        PauseVolume.text = sliderCopy.value.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        DoExitMenu();
        ActivatePauseMenu();
        if(timerActive)
        {
            UpdateTimer();
        }
        
    }
    public void doExitGame()
    {
        Application.Quit();
    }
    
    public void DoExitMenu()
    {
        if(Input.GetKeyDown("x"))
        {
            StartScreen.SetActive(false);
            MainMenu.SetActive(true);
        }
    }
    public void StartTimer()
    {
        if(StartScreen.activeSelf)
        {
            timerActive = true;
        }
    }

    private void UpdateTimer()
    {
        timer += Time.deltaTime;
    
        timerText.text = timer.ToString("0:00");
        
    }
    public void SetSlider()
    {
        sliderCopy.value = slider.value;
    }

    public void SetSliderCopy()
    {
        slider.value = sliderCopy.value;
    }
    public void ActivatePauseMenu()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && StartScreen.activeSelf == true)
        {
            StartScreen.SetActive(false);
            MainMenu.SetActive(false);
            PauseMenu.SetActive(true);
            Blurred.SetActive(true);
        }
    }
    
}
