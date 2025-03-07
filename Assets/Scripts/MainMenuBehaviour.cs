using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuBehaviour : MonoBehaviour
{

    [SerializeField]
    Canvas mainMenu, optionsMenu;

    [SerializeField]
    Slider volumeSlider;

    [SerializeField]
    Toggle mute;

    // Start is called before the first frame update
    void Start()
    {
        mainMenu.enabled = true;
        optionsMenu.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            mainMenu.enabled = false;
            optionsMenu.enabled = true;
        }
    }

    public void Return()
    {
        mainMenu.enabled = true;
        optionsMenu.enabled = false;
    }

    public void ChangeVolume()
    {
        if (mute.isOn)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = volumeSlider.value;
        }
    }
}
