using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteObject : MonoBehaviour
{
    public bool canBePressed;
    public KeyCode keytoPress;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keytoPress))
        {
            if (canBePressed)
            {
                if (Mathf.Abs(transform.position.y) > 0.9)
                {
                    GameManager.instance.BadHit();
                }
                else if (Mathf.Abs(transform.position.y) > 0.3)
                {
                    GameManager.instance.GoodHit();
                }
                else GameManager.instance.PerfectHit();
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "target")
        {
            canBePressed = true;
        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "target")
        {
            canBePressed = false;
            GameManager.instance.NoteMiss();
        }


    }
}