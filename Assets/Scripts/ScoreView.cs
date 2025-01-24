using UnityEngine;
using TMPro;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _highScoredText;

    public void UpdateHighScoreView(int highScore)
    {
        _highScoredText.text = highScore.ToString();
    }

    public void UpdateScoreView(int currentScore)
    {
        _currentScoreText.text = currentScore.ToString();
    }
}
