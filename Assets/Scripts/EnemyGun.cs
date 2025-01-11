using System.Collections;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _bulletSpeed;

    private void Start()
    {
        StartCoroutine(CreateBullet());
    }
    private IEnumerator CreateBullet()
    {
        while (true)
        {
            GameObject newBullet = Instantiate(_bulletPrefab, transform.position, transform.rotation);
            newBullet.GetComponent<Rigidbody2D>().velocity = -transform.right * _bulletSpeed * Time.deltaTime;

            yield return new WaitForSeconds(2f);
        }
    }

}
