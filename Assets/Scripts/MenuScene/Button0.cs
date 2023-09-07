using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button0 : MonoBehaviour
{
    Button0 button;
    private void Awake()
    {
        button = GetComponent<Button0>();
    }
    public void OnClick()
    {
        PlayerPrefs.SetInt("Char",0);
        Transform selectTransform = GameObject.Find("Select").transform;
        foreach (Transform child in selectTransform)
        {
            child.gameObject.SetActive(false);
        }
        selectTransform.gameObject.SetActive(false);
    }
}
