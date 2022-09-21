using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceSceneManager : MonoBehaviour
{
    public int points;
    public int DEF_POINTS = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void AddPoints()
    {
        this.points += DEF_POINTS;
    }
    void AddPoint(int somePoints)
    {
        this.points += somePoints;
    }
}
