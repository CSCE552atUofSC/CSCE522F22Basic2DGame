using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpaceSceneManager : MonoBehaviour
{
    public int points;
    public int DEF_POINTS = 100;
    public TMP_Text lblPoints;

    public float MAX_TIME = 300;
    float currTime;
    public TMP_Text lblTime;

    public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        currTime = MAX_TIME;
        gameManager = GameObject.FindGameObjectWithTag("Game Manager");
    }

    // Update is called once per frame
    void Update()
    {
        lblPoints.text = points.ToString();
        lblTime.text = ((int)currTime).ToString();

        currTime -= Time.deltaTime;
        if (currTime <= 0.0f)
            gameManager.SendMessage("NextScene");
    }
    void AddPoints()
    {
        this.points += DEF_POINTS;
    }
    void AddPoint(int somePoints)
    {
        this.points += somePoints;
    }
    /*
    private void OnGUI()
    {
        
    }*/
}
