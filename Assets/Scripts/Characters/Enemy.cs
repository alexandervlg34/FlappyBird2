using UnityEngine;

public class Enemy : MonoBehaviour, IInteractable
{
    public void Destroy()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out IInteractable interactable))
        {
            GameManager.instance.GameOver();
        }
    }
}
