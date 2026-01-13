using UnityEngine;


public class EnemyGenerator : MonoBehaviour
{
  [SerializeField] EnemyObj enemyPrefab;
  [SerializeField] Transform parent;
  [SerializeField] EnemyManager enemyManager;

  public void Setup()
  {
    Spawn();
  }

  EnemyObj Spawn()
  {
    var enemy = Instantiate(enemyPrefab, parent);
    enemy.transform.localPosition = Vector3.zero;
    enemyManager.AddEnemy(enemy);
    return enemy;
  }
}
