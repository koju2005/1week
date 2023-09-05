using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public TMP_InputField inputname;
   public void OnClick()
    {
        PlayerPrefs.SetString("Name", inputname.text);
        SceneManager.LoadScene("MainScene");
    }
}
