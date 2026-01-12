using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using TMPro;

public class CardObj : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
// MonoBehaviourクラスの継承、IDragHandlerインターフェースの実装
{
  [SerializeField] Text nameText;
  [SerializeField] Text descriptionText;
  [SerializeField] Image icon;
  [SerializeField] Text costText;

  CanvasGroup canvasGroup;
  public UnityAction OnEndDragAction;

  void Awake()
  {
    canvasGroup = GetComponent<CanvasGroup>();
  }

  // カードのドラッグを開始した時にRaycast（当たり判定）を止める
  public void OnBeginDrag(PointerEventData eventData)
  {
    canvasGroup.blocksRaycasts = false;
  }

  // カードのドラッグをした時にマウス位置を追従させる
  public void OnDrag(PointerEventData eventData)
  {
    transform.position = eventData.position;
  }

  // カードのドラッグを終えた時に元の位置に戻す
  public void OnEndDrag(PointerEventData eventData)
  {
    canvasGroup.blocksRaycasts = true;
    OnEndDragAction?.Invoke();
  }

}
