using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallOut : MonoBehaviour
{
    public static int outLimit = 10;
    // Start is called before the first frame update
    void Start()
    {
        outLimit = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) {
        if(GameMaster.cleared == false)outLimit--;
        
        if (outLimit <= 0)
        {
            outLimit = 0;
            GameObject.Find("Master").GetComponent<GameMaster>().GameOver("Too bad!\nlet's try again.");
        }
    }
}
