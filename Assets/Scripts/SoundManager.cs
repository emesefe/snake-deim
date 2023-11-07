using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SoundManager 
{
    public enum Sound
    {
        ButtonClick,
        ButtonOver,
        SnakeDie,
        SnakeEat,
        SnakeMove
    }
    
    public static void PlaySound()
    {
        GameObject soundGameObject = new GameObject("Sound Manager");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        //audioSource.PlayOneShot(GameAssets.Instance.snakeMoveClip);
    }
}
