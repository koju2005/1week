using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    SoundManager soundManager;
    AudioSource m_AudioSource;
    public TMP_InputField inputname;
    public void OnClick()
    {
        SoundManager.instance.PlaySound();
        PlayerPrefs.SetString("Name", inputname.text);
       SceneManager.LoadScene("MainScene");
    }
}
