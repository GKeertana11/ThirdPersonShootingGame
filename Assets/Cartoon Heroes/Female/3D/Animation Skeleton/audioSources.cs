using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioSources : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audioSource;
    public List<AudioClip> audioClips;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ShotFire()
    {
        audioSource.PlayOneShot(audioClips[0]);
    }

    public void PlayerJump()
    {
        audioSource.PlayOneShot(audioClips[1]);
    }
}
