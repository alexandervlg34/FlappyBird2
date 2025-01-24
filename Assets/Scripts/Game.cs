using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private GameObject _gameOverCanvas;

    private void OnEnable()
    {
        _bird.Died += OnGameOver;
    }

    private void OnDisable()
    {
        _bird.Died -= OnGameOver;
    }

    private void Awake()
    {
        Time.timeScale = 1f;
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
