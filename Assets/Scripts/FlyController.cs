using UnityEngine;

public class FlyController : MonoBehaviour
{
    [SerializeField] private float _velocity;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private Rigidbody2D _rigidbody;

    public void Rotate()
    {
        transform.rotation = Quaternion.Euler(0, 0, _rigidbody.velocity.y * _rotationSpeed);
    }

    public void MoveUp()
    {
        _rigidbody.velocity = Vector2.up * _velocity;
    }
}
  