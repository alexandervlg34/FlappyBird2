using UnityEngine;

public class BirdGun  : MonoBehaviour
{
    [SerializeField] private BirdBullet _bulletPrefab;
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
       Instantiate(_bulletPrefab, transform.position, transform.rotation);
    }
}
