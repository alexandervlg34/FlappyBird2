using UnityEngine;

public class EnemyBullet : MonoBehaviour
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
        _rigidbody.velocity = -transform.right * _bulletSpeed * Time.deltaTime;
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}

