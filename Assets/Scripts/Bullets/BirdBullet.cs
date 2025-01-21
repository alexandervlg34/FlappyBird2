using UnityEngine;

public class BirdBullet : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _bulletSpeed;
    [SerializeField] private float _activeArea;

    private void Update()
    {
        if(_transform.position.x > _activeArea)
        {
            Destroy();
        }
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = transform.right * _bulletSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent(out Ground ground))
        {
            Destroy();
        }
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
