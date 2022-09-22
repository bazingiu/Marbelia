using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor.UI;

namespace Minigioco2
{
    public class MainMenu : MonoBehaviour
    {
        [Header("Volume Setting")]
        [SerializeField] private Text volumetTextValue = null;
        [SerializeField] private Slider volumeSlider = null;
        [SerializeField] private GameObject confirmationPrompt = null;
        [SerializeField] private float defaultVolume = 0.5f;
        [SerializeField] GameObject menu; 

        bool pause = false;
        public void Update()
        {
            if (Input.GetKeyDown("escape"))
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
            //SceneManager.LoadScene("MainMenu");
        }

        public void SetVolume(float volume)
        {
            AudioListener.volume = volume;
            volumetTextValue.text = volume.ToString("0.0");
        }

        public void VolumeApply()
        {
            PlayerPrefs.SetFloat("mastervolume", AudioListener.volume);
            //Show Prompt
            StartCoroutine(ConfirmationBox());
        }

        public IEnumerator ConfirmationBox()
        {
            confirmationPrompt.SetActive(true);
            yield return new WaitForSeconds(2);
            confirmationPrompt.SetActive(false);
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