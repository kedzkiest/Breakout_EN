using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySE : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip wallReflection;

    public AudioClip hitBlock;

    public AudioClip clear;

    public AudioClip failed;

    private bool finishFlag;
    // Start is called before the first frame update
    void Start()
    {
        finishFlag = false;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameMaster.cleared && finishFlag == false)
        {
            finishFlag = true;
            audioSource.PlayOneShot(clear);
        }

        if (WallOut.outLimit <= 0 && finishFlag == false)
        {
            finishFlag = true;
            audioSource.PlayOneShot(failed);
        }
    }
    
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Wall")
        {
            audioSource.PlayOneShot(wallReflection);
        }

        if (collision.gameObject.tag == "Point" && WallOut.outLimit > 0)
        {
            audioSource.PlayOneShot(hitBlock);
        }
    }
}
