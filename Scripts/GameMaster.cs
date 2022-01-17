using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{

    public int blockNum;
    public float nowTime;
    private float clearTime;
    public Canvas resultCanvas;
    public Text resultText;

    public static bool cleared = false;
    
    // Start is called before the first frame update
    void Start()
    {
        cleared = false;
        resultCanvas.enabled = false;
        nowTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        nowTime += Time.deltaTime;

        if (blockNum > 0)
        {
            clearTime = nowTime;
        }
        
        if(blockNum <= 0)
        {
            cleared = true;
            GameOver("Congratulations！\n" + "Clear Time: " + clearTime.ToString("F0"));
        }
    }
    public void GameOver(string resultMessage)
    {
        resultCanvas.enabled = true;
        resultText.text = resultMessage;
    }

}
