using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public static SoundController Instance;
    AudioSource audioSource;
    [SerializeField] AudioClip pickedValuableCoin;
    [SerializeField] AudioClip pickedUnvaluableCoin;
    void Start()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    ///<summary>
    ///Play audio according to the audioclip provided
    ///</summary>
    private void PlayAudio(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }
    public void CoinCollect()
    {
        PlayAudio(pickedUnvaluableCoin);
    }
    public void WrongCoinCollect()
    {
       PlayAudio(pickedUnvaluableCoin);
    }
}
