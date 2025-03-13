using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chimp : MonoBehaviour
{
    private SpriteRenderer chimp;
    public Sprite defaultChimp;
    public Sprite clapChimp;
    public KeyCode keytoPress;
    // Start is called before the first frame update
    void Start()
    {
        chimp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keytoPress))
        {
            chimp.sprite = clapChimp;
        }
        if (Input.GetKeyUp(keytoPress))
        {
            chimp.sprite = defaultChimp;
        }
    }
}
