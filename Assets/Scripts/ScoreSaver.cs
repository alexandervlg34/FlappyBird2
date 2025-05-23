using UnityEngine;

public class ScoreSaver : MonoBehaviour
{
    private const string HIGHSCORE = "HighScore";

    [SerializeField] private SuccessMark _playerSuccess;
    [SerializeField] private ScoreView _scoreView;

    private int _score;

    private void Start()
    {
        _playerSuccess.GotSuccess += UpdateScore;
        UpdateHighScore();
        _scoreView.UpdateScoreView(_score);
        _scoreView.UpdateHighScoreView(PlayerPrefs.GetInt(HIGHSCORE, 0));
    }

    private void UpdateHighScore()
    {
        if (_score > PlayerPrefs.GetInt(HIGHSCORE))
        {
            PlayerPrefs.SetInt(HIGHSCORE, _score);
            _scoreView.UpdateHighScoreView(PlayerPrefs.GetInt(HIGHSCORE, 0));
        }
    }

    public void UpdateScore()
    {
        _score++;
        UpdateHighScore();
        _scoreView.UpdateScoreView(_score);
    }
}
