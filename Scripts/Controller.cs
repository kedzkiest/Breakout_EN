using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (WallOut.outLimit > 0)
        {
            if (Input.GetKey(KeyCode.RightArrow)) {
                transform.Translate(0, 0, -speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.LeftArrow)) {
                transform.Translate(0, 0,speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.UpArrow)) {
                transform.Translate(speed * Time.deltaTime, 0,0);
            }
            else if (Input.GetKey(KeyCode.DownArrow)) {
                transform.Translate(-speed * Time.deltaTime, 0,0);
            }
        }
        
    }
}
