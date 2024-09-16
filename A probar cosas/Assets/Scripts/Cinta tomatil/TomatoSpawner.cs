using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TomatoSpawner : MonoBehaviour
{
    [SerializeField] private float _beltSpeed;
    [SerializeField] private Vector2 _beltDirection;
    [SerializeField] private float _spawnCoolDown;

    [SerializeField] private GameObject _goodTomatoPrefab, _badTomatoPrefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _badSpawnChance;

    private void Start()
    {
        StartCoroutine(TomatoSpawnerCoroutine()); 
    }
    private bool IsBadSpawn()
    {
        return Random.Range(1, 100) <= _badSpawnChance;
    }

    private IEnumerator TomatoSpawnerCoroutine()
    {
        while (true)
        {
            for (int i = 0; i < _spawnPoints.Length; i++)
            {
                int randomIndex = Random.Range(i, _spawnPoints.Length - 1);
                (_spawnPoints[i], _spawnPoints[randomIndex]) = (_spawnPoints[randomIndex], _spawnPoints[i]);
            }

            foreach (Transform spawnPoint in _spawnPoints)
            {
                GameObject prefabToSpawn = IsBadSpawn()
                    ?_badTomatoPrefab
                    :_goodTomatoPrefab;
                
                GameObject tomato = Instantiate(prefabToSpawn, spawnPoint.position, Quaternion.identity);
                FixedDirectionTomatoMover movement = tomato.GetComponent<FixedDirectionTomatoMover>();
                movement.SetSpeedAndDirection(_beltSpeed, _beltDirection);

                float randomTimeInterval = Random.Range(-0.5f, 0.5f);
                yield return new WaitForSeconds(_spawnCoolDown + randomTimeInterval);
            }
        }
    }

}
