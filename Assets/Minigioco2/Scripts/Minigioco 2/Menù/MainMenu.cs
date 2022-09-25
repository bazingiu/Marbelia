using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

namespace Minigioco2
{
    public class MainMenu : MonoBehaviour
    {
        [Header("Volume Setting")]
        [SerializeField] private Text volumetTextValue = null;
        [SerializeField] private Slider volumeSlider = null;
        [SerializeField] private float defaultVolume = 0.5f;
        [SerializeField] GameObject menu;
        UnityEvent m_MyEvent;

        bool pause = false;

        public void Awake()
        {
            menu.SetActive(false);
        }

        public void Start()
        {
            m_MyEvent = new UnityEvent();
            m_MyEvent.AddListener(managePauseMenu);
        }
        public void Update()
        {
            if (Input.GetKeyDown("escape"))
            {
                m_MyEvent.Invoke();
            }
        }

        void managePauseMenu()
        {
            pause = !pause;
            if (pause == false)
            {
                Disable();
                Time.timeScale = 1;
            }
            else
            {
                Setup();
                Time.timeScale = 0;
            }
        }
        public void Setup()
        {
            menu.SetActive(true);
        }

        public void Disable()
        {
            menu.SetActive(false);
        }

        public void ExitButton()
        {
            SceneManager.LoadScene("MainMenu");
        }

        public void SetVolume(float volume)
        {
            AudioListener.volume = volume;
            volumetTextValue.text = volume.ToString("0.0");
        }

        public void VolumeApply()
        {
            PlayerPrefs.SetFloat("mastervolume", AudioListener.volume);
        }

        public void resetButton(string MenuType)
        {
            if(MenuType == "Audio")
            {
                AudioListener.volume = defaultVolume;
                volumeSlider.value = defaultVolume;
                volumetTextValue.text = defaultVolume.ToString("0.0");
                VolumeApply();
            }
        }

        public void RestartButton()
        {
            pause = false;
            Disable();
            Time.timeScale = 1;
        }
    }
}