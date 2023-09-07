using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour
{
    Button1 button;
    private void Awake()
    {
        button = GetComponent<Button1>();
    }
    public void OnClick()
    {
        PlayerPrefs.SetInt("Char",1);
        Transform selectTransform = GameObject.Find("Select").transform;
        foreach (Transform child in selectTransform)
        {
            child.gameObject.SetActive(false);
        }
        selectTransform.gameObject.SetActive(false);
    }
}
