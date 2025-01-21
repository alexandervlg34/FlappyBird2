using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private GameObject _gameOverCanvas;

    private void Awake()
    {
        Time.timeScale = 1f;
        _bird.Died += OnGameOver;
    }

    public void OnGameOver()
    {
        _gameOverCanvas.SetActive(true);

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
