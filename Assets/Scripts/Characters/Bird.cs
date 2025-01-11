using UnityEngine;

public class Bird : MonoBehaviour, IInteractable
{
    public void Destroy()
    {
        gameObject.SetActive(false);
        GameManager.instance.GameOver();
    }
}
