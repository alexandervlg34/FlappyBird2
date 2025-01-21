using System;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public event Action Died;
    public event Action GotSuccess;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out EnemyBullet enemyBullet))
        {
            Died?.Invoke();
            gameObject.SetActive(false);
        }
        else if (collision.gameObject.TryGetComponent(out PipeIncreaseScore pipeIncreaseScore))
        {
            GotSuccess?.Invoke();
        }
        else 
        {
            Died?.Invoke();
        }
    } 
}
