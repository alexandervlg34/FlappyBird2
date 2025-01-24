using System;
using UnityEngine;

public class PlayerSuccess : MonoBehaviour
{
    public event Action GotSuccess;

    private bool _isBird;

    private void Start()
    {
        _isBird = gameObject.TryGetComponent(out Bird bird);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_isBird)
        {
            if (collision.gameObject.TryGetComponent(out PipeIncreaseScore pipeIncreaseScore))
            {
                GotSuccess?.Invoke();
            }
        }
    }
}
