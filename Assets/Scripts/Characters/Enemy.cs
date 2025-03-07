using System;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class Enemy : MonoBehaviour
{
    public event Action Died;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out BirdBullet bullet))
        {
            Died?.Invoke();
            gameObject.SetActive(false);
        }
    }
}
