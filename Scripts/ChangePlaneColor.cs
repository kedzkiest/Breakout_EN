using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlaneColor : MonoBehaviour
{
    public Material material;

    private float duration = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float blacken = WallOut.outLimit / 10.0f;
        Color nowColor = material.color;
        Color newColor = new Color(blacken, blacken,blacken, 1);
        
        float lerp = Mathf.PingPong(Time.time, duration) / duration;
        material.color = Color.Lerp(nowColor, newColor, lerp);

    }
}
