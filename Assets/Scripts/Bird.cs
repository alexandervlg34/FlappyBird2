using System;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public event Action Died;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out EnemyBullet enemyBullet))
        {
            Died?.Invoke();
            gameObject.SetActive(false);
        }

        if (collision.gameObject.TryGetComponent(out DeathZone deathZone))
        {
            Died?.Invoke();
        }
    }
}
