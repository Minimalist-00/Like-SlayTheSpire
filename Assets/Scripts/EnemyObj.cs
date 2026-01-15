using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyObj : MonoBehaviour, IDropHandler
{
  [SerializeField] int hp;
  [SerializeField] int at;
  public void OnDrop(PointerEventData eventData)
  {
    CardObj cardObj = eventData.pointerDrag.GetComponent<CardObj>();
    cardObj.Use(this);
  }

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
