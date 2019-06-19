using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnTriggerEnter : MonoBehaviour
{
    AudioSource thisDrumAudioSource;
    public AudioClip thisDrumClip;
    ParticleSystem hitPFX;

    // Start is called before the first frame update
    void Start()
    {
        thisDrumAudioSource = gameObject.GetComponent<AudioSource>();
        hitPFX = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (!thisDrumAudioSource.isPlaying)
        //{
        thisDrumAudioSource.PlayOneShot(thisDrumClip);
        hitPFX.Play();
        Debug.Log("hit");
        //}
    }
}
