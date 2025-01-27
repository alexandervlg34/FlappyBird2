using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _bulletSpeed;
    [SerializeField] private float _activeArea;

    private void Update()
    {
        if (_transform.position.x > _activeArea || _transform.position.x < -_activeArea)
        {
            Destroy();
        }
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = transform.right * _bulletSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out DeathZone border))
        {
            Destroy();
        }
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
