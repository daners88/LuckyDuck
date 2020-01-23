using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundRandomizer : MonoBehaviour
{
    private AudioSource _audioSource;
    public List<AudioClip> sounds = null;
    public float smallestGap = 10f;
    float timeElapsed = 0f;
    System.Random rand = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if(timeElapsed > smallestGap)
        {
            if(rand.Next(0,100) > 92)
            {
                _audioSource.clip = sounds[rand.Next(0, 4)];
                _audioSource.Play();
                timeElapsed = 0f;
            }
        }
    }
}
