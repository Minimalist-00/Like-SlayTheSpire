using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyObj : MonoBehaviour, IDropHandler
{
  [SerializeField] int hp;
  public void OnDrop(PointerEventData eventData)
  {
    CardObj cardObj = eventData.pointerDrag.GetComponent<CardObj>();
    cardObj.Use(this);
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
