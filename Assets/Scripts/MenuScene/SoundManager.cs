using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    static public SoundManager instance; // 버튼에 달지말자 오디오 소스 ㅠㅠ
    AudioSource audio;
    private void Awake()
    {
        audio = GetComponent<AudioSource>();
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(this.gameObject);
    }
   public void PlaySound()
    {
        audio.Play();
    }
}
