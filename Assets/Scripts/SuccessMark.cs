using System;
using UnityEngine;

public class SuccessMark : MonoBehaviour
{
    public event Action GotSuccess;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PipeIncreaseScore pipeIncreaseScore))
        {
            GotSuccess?.Invoke();
        }
    }
}
