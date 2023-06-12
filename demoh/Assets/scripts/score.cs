using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class score : MonoBehaviour
{
    [SerializeField] private TMP_Text textScore;

    [SerializeField] private TMP_Text finalScore;

    [SerializeField] private int Score;

    private int finalScoreNum;

    private void Update()
    {
        textScore.text = "" + Score;
        Score++;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            finalScoreNum = Score;
            finalScore.text = "" + finalScoreNum;
        }
    }
}
