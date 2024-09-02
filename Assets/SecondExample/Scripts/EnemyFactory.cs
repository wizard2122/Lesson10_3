using System;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyFactory", menuName = "Factory/EnemyFactory")]
public class EnemyFactory: ScriptableObject
{
    [SerializeField] private EnemyConfig _small, _medium, _large;

    public Enemy Get(EnemyType enemyType, Vector3 position)
    {
        EnemyConfig config = GetConfigBy(enemyType);
        Enemy instance = Instantiate(config.Prefab, position, Quaternion.identity, null);
        instance.Initialize(config.Health, config.Speed);
        return instance;
    }

    private EnemyConfig GetConfigBy(EnemyType enemyType)
    {
        switch (enemyType)
        {
            case EnemyType.Small:
                return _small;

            case EnemyType.Medium:
                return _medium; 

            case EnemyType.Large:
                return _large;  

            default:
                throw new ArgumentException(nameof(enemyType)); 
        }
    }
}
