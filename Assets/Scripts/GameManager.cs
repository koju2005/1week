using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
     public TMP_Text tmp;
    void Awake()
    {
         string name = PlayerPrefs.GetString("Name");
        tmp.text = name;
    }
}
