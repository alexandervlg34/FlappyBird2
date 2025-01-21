using UnityEngine;
using UnityEngine.InputSystem;

public class FlyController : MonoBehaviour
{
    [SerializeField] private float _velocity;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private Rigidbody2D _rigidbody;

    private bool _isMousePressed = false;

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            _isMousePressed = true;
        }
    }

    private void FixedUpdate()
    {
        if (_isMousePressed)
        {
            _rigidbody.velocity = Vector2.up * _velocity;
            _isMousePressed = false;
        }

        transform.rotation = Quaternion.Euler(0, 0, _rigidbody.velocity.y * _rotationSpeed);
    }
}
  