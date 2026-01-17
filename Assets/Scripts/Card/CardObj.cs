using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using TMPro;
using JetBrains.Annotations;

public class CardObj : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
// MonoBehaviourクラスの継承、IDragHandlerインターフェースの実装
{
  [SerializeField] Text nameText;
  [SerializeField] Text descriptionText;
  [SerializeField] Image icon;
  [SerializeField] Text costText;

  CanvasGroup canvasGroup;
  public UnityAction OnEndDragAction;
  public UnityAction<CardObj> OnUseAction;

  void Awake()
  {
    canvasGroup = GetComponent<CanvasGroup>();
  }

  public void Use(EnemyObj enemy)
  {
    // todo カード効果が固定されている
    enemy.Damage(4);
    OnUseAction?.Invoke(this);
  }

  // カードの中身をセットする
  public void SetCardData(CardData data)
  {
    nameText.text = data.Name;
    descriptionText.text = data.Description;
    icon.sprite = data.Icon;
    costText.text = data.Cost.ToString();
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
