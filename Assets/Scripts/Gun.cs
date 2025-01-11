using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _bulletSpeed;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CreateBullet();
        }
    }

    private void CreateBullet()
    {
        GameObject newBullet = Instantiate(_bulletPrefab, transform.position, transform.rotation);
        newBullet.GetComponent<Rigidbody2D>().velocity = transform.right * _bulletSpeed * Time.deltaTime;
    }
}
