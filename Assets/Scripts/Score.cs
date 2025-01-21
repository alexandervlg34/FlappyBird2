using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    
    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _highScoredText;

    private const string HIGHSCORE = "HighScore";
    private int _score;

    private void Start()
    {
        _bird.GotSuccess += UpdateScore;
        _currentScoreText.text = _score.ToString();
        _highScoredText.text = PlayerPrefs.GetInt(HIGHSCORE, 0).ToString();
        UpdateHighScore();
    }

    private void UpdateHighScore()
    {
        if(_score > PlayerPrefs.GetInt(HIGHSCORE))
        {
            PlayerPrefs.SetInt(HIGHSCORE, _score);
            _highScoredText.text = _score.ToString();
        }
    }

    public void UpdateScore()
    {
        _score++;
        _currentScoreText.text = _score.ToString();
        UpdateHighScore();
    }
}
