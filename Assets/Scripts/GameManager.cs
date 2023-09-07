using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    void Awake()
    {
        string name = PlayerPrefs.GetString("Name");
        Transform textTransform = Player.transform.Find("Canvas/NameText");
        
        if (textTransform != null)
        {
            TMP_Text tmp = textTransform.GetComponent<TMP_Text>();
            tmp.text = name;
        }
        


        Instantiate(Player);
    }
}
