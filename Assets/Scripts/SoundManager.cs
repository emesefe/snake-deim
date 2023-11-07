using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SoundManager 
{
    public static void PlaySound()
    {
        GameObject soundGameObject = new GameObject("Sound Manager");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GameAssets.Instance.snakeMoveClip);
    }
}
