using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyObj : MonoBehaviour, IDropHandler
{
  // カードをドロップした時にログを出す
  public void OnDrop(PointerEventData eventData)
  {
    Debug.Log("ドロップされた");
  }
}
