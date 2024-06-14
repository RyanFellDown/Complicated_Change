using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    [SerializeField]
    AudioSource audioSource;
    public float timeToPlay;

    private void Start()
    {
        StartCoroutine(PlaySoundSpecificTime(timeToPlay));
    }


    IEnumerator PlaySoundSpecificTime(float timeWanted)
    {
        yield return new WaitForSeconds(timeWanted);
        audioSource.Play();
    }
}
