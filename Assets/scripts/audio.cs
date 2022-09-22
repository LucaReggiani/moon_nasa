using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{

    AudioSource myAudio;
    // Start is called before the first frame update
    void Start() {
        
        myAudio = GetComponent<AudioSource>();
        Invoke("playAudio", 47.0f); 
    }
    
    void playAudio() {
    
        myAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
