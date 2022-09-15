using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro
public class ScoreManeger : MonoBehaviour
{
    
    public int score;
    public TextMeshProUGUI scoreText
    
    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();    
    }

    public void IncreaseScoreText(intamount)
    {
        score =+ amount;
        UpdateScoreText();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
