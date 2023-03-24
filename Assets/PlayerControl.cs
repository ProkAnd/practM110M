using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{

    // Start is called before the first frame update
    
    public GameObject GameOver;
    public Text live;
    public static int LiveScore=1;
    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
        }
        if(LiveScore==0)
        {
            GameOver.SetActive(true);
        }
    }

    // Update is called once per frame
    public void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 250));
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.tag=="Enemy")
        {
            LiveScore--;
            live.text=LiveScore.ToString();
        }
    }
}
