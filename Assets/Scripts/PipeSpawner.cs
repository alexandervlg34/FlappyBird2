using UnityEngine;
using System.Collections;
public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float _maxTime;
    [SerializeField] private float _upperYPosition;
    [SerializeField] private float _bottomYPosition;
    [SerializeField] private GameObject _spawnedObject;
    [SerializeField] private ScoreSaver _scoreSaver;
    
    private float _timer;

    private void Start()
    {
        (_bottomYPosition, _upperYPosition) = _spawnedObject.gameObject.TryGetComponent(out Pipe pipe)
            ? (-0.45f, 0.45f)
            : (-0.45f, 1f);

        SpawnObject();
    }

    private void Update()
    {
        if(_timer > _maxTime)
        {
            SpawnObject();
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }

    private void SpawnObject()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(_bottomYPosition, _upperYPosition));
        GameObject spawnedObject = Instantiate(_spawnedObject, spawnPos, Quaternion.identity);
        
        StartCoroutine(Defeat(spawnedObject));
    }

    private IEnumerator Defeat(GameObject spawnedObject)
    {
        yield return new WaitForSeconds(5f);
        Destroy(spawnedObject);  
    }
}