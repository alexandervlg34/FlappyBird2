using System.Collections;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    [SerializeField] private EnemyBullet _bulletPrefab;
    
    private void Start()
    {
        StartCoroutine(CreateBullet());
    }

    private IEnumerator CreateBullet()
    {
        while (true)
        {
            Instantiate(_bulletPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }
}
