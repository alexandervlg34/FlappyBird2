using UnityEngine;

public enum TypeOfObject
{
    Pipe,
    Enemy
}

public class Spawner : MonoBehaviour
{
    public TypeOfObject typeOfObject;

    [SerializeField] private float _maxTime;
    [SerializeField] private float _upperYPosition;
    [SerializeField] private float _bottomYPosition;
    [SerializeField] private GameObject _spawnedObject;
    [SerializeField] private Score _score;
    
    private float _timer;

    private void Start()
    {
        if(typeOfObject == TypeOfObject.Pipe)
        {
            _bottomYPosition = -0.45f;
            _upperYPosition = 0.45f;
        }
        else
        {
            _bottomYPosition = -0.45f;
            _upperYPosition = 1f;
        }

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

        if(spawnedObject.gameObject.TryGetComponent(out Enemy enemy))
        {
            enemy.Died += _score.UpdateScore; 
        }

        Destroy(spawnedObject, 5f);
    }
}
