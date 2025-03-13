using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;
    public bool startPlaying;
    public noteScroll ns;

    public static GameManager instance;
    public int currentScore;
    public int perPerfect;
    public int perGood;
    public int perBad;
    public int currentCombo;

    public Text scoreText;
    public Text comboText;

    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                ns.hasStarted = true;
                theMusic.Play();
            }
        }
    }

    public void NoteHit()
    {
        currentCombo += 1;
        scoreText.text = "Score: " + currentScore;
        comboText.text = "Combo: " + currentCombo;
    }

    public void PerfectHit()
    {
        currentScore += perPerfect;
        NoteHit();
    }

    public void GoodHit()
    {
        currentScore += perGood;
        NoteHit();
    }

    public void BadHit()
    {
        currentScore += perBad;
        NoteHit();
    }


    public void NoteMiss()
    {
        currentCombo = 0;
        comboText.text = "Combo: " + currentCombo;
    }
}
