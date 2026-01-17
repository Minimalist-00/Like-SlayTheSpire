using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using System.Reflection;
using UnityEngine.UI;
public class CardObj : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
// MonoBehaviourクラスの継承、IDragHandlerインターフェースの実装
{
  [SerializeField] TextMeshProUGUI nameText;
  [SerializeField] TextMeshProUGUI descriptionText;
  [SerializeField] Image icon;
  [SerializeField] TextMeshProUGUI costText;
  CardData cardData;
  CanvasGroup canvasGroup;
  public UnityAction OnEndDragAction;
  public UnityAction<CardObj> OnUseAction;
  PlayerObj player;
  EnemyObj enemy;

  void Start()
  {
    player = FindObjectOfType<PlayerObj>();
    enemy = FindObjectOfType<EnemyObj>();
  }
  void Awake()
  {
    canvasGroup = GetComponent<CanvasGroup>();
  }

  public void Use()
  {
    // カード効果がAttackの時の処理
    if (cardData.CardType == CardType.Attack)
    {
      enemy.Damage(cardData.Attack);
    }

    if (cardData.CardType == CardType.Defense)
    {
      Debug.Log("防御カードを使ったよ！");
      player.AddDefense(cardData.Defense);
    }
    OnUseAction?.Invoke(this); // 登録したアクションを呼び出す
  }

  // カードの中身をセットする
  public void SetCardData(CardData data)
  {
    cardData = data; // メンバ変数に入れておく（後で使うからね）
    nameText.text = data.Name;
    descriptionText.text = data.Description;
    icon.sprite = data.Icon;
    costText.text = data.Cost.ToString();
  }

  // カードのドラッグを開始した時にRaycast（当たり判定）を止める
  public void OnBeginDrag(PointerEventData eventData)
  {
    Debug.Log("ドラッグ開始");
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
    canvasGroup.blocksRaycasts = true; // 当たり判定をもとに戻す
    Use();
    OnEndDragAction?.Invoke();
  }
}
