using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    int count=0;
    public Text textCount;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("countTime", 1f, 1f);
    }
    private void countTime()
    {
        if (PlayerControl.LiveScore>0)
        {
            count++;
        textCount.text=count.ToString();
        }
        else if (PlayerControl.LiveScore<=0)
        {
        textCount.text=count.ToString();
        }
    }
    void Update()
    {
        
    }
}
