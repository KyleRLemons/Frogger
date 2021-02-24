using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scorescript : MonoBehaviour
{
    
    public TextMeshProUGUI TMPScore;
    public TextMeshProUGUI TMPLives;
    public TextMeshProUGUI TMPName;
    void Start()
    {
        TMPScore.text = "Score: " + Frog.Score;
        TMPLives.text = "Lives: " + Frog.NumberofLives;
        TMPName.text = Frog.Name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
