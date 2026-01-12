using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
  [SerializeField] EnemyObj enemyPrefab;
  [SerializeField] Transform parent;

  private void Start()
  {
    Spawn();
  }

  EnemyObj Spawn()
  {
    var enemy = Instantiate(enemyPrefab, parent);
    enemy.transform.localPosition = Vector3.zero;
    return enemy;
  }
}
