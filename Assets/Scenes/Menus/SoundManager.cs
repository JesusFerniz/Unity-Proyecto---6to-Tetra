using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volumenslider;

    private void Start()
    {
        if(!PlayerPrefs.HasKey("musicVolumen"))
        {
            PlayerPrefs.SetFloat("musicVolumen", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void ChangeVolumen()
    {
        AudioListener.volume = volumenslider.value;
        Save();
    }

    public void Load()
    {
        volumenslider.value = PlayerPrefs.GetFloat("musicVolumen");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolumen", volumenslider.value);
    }

}
