using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Levelaudio : MonoBehaviour
{
    public AudioSource AudioSource;
        private void Awake()
    {
        StartCoroutine(Song());
    }

    IEnumerator Song()
    {
        yield return new WaitForSeconds(0.2f);
        AudioSource.Play();
    }
}
