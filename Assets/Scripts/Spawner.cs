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
    [SerializeField] private float _heightRange;
    [SerializeField] private GameObject _pipe;

    private float _timer;

    private void Start()
    {
        if(typeOfObject == TypeOfObject.Pipe)
        {
            _heightRange = 0.45f;
        }
        else
        {
            _heightRange = 1f;
        }
        
        SpawnPipe();
    }

    private void Update()
    {
        if(_timer > _maxTime)
        {
            SpawnPipe();
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange));
        GameObject pipe = Instantiate(_pipe, spawnPos, Quaternion.identity);

        Destroy(pipe, 10f);
    }
}
