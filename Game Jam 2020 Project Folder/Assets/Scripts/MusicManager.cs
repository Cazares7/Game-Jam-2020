using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource song1;
    public AudioSource song2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public AudioSource GetSong() {
        return song1;
    }

    public AudioSource GetGameOverSong() {
        return song2;
    }
}
