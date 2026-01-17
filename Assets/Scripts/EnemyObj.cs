using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyObj : MonoBehaviour
{
  [SerializeField] int hp;
  [SerializeField] int at;

  public void Action(PlayerObj player)
  {
    player.Damage(at);
  }

  public void Damage(int damage)
  {
    hp -= damage;
    if (hp <= 0)
    {
      Destroy(gameObject);
    }
  }
}
