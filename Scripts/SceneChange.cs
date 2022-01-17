using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

public class SceneChange : MonoBehaviour
{
    public static int sceneFlag = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && sceneFlag == 1)
        {
            gotoMain();
        }

        if (sceneFlag == 2)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                gotoMain();
            }
            else if (Input.GetKeyDown(KeyCode.T))
            {
                backTitle();
            }
        }

    }

    public void backTitle(){
        sceneFlag = 1;
        SceneManager.LoadScene("Title");
    }

    public void gotoMain(){
        sceneFlag = 2;
        SceneManager.LoadScene("Main");
    }
}
