using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class CardObj : MonoBehaviour, IDragHandler, IEndDragHandler
// MonoBehaviourクラスの継承、IDragHandlerインターフェースの実装
{
  [SerializeField] Text nameText;
  [SerializeField] Text descriptionText;
  [SerializeField] Image icon;
  [SerializeField] Text costText;

  public UnityAction OnEndDragAction;

  // カードのドラッグをした時にマウス位置を追従させる
  public void OnDrag(PointerEventData eventData)
  {
    transform.position = eventData.position;
  }

  // カードのドラッグを終えた時に元の位置に戻す
  public void OnEndDrag(PointerEventData eventData)
  {
    OnEndDragAction?.Invoke();
  }
}
