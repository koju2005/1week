using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SelectButton : MonoBehaviour
{

    public void OnClick()
    {
        Transform selectTransform = GameObject.Find("Select").transform;

        foreach (Transform child in selectTransform)
        {
            child.gameObject.SetActive(true);
        }
    }
}
