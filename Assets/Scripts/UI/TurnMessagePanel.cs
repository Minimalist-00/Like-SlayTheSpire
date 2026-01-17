using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnMessagePanel : MonoBehaviour
{
  [SerializeField] GameObject panel;
  [SerializeField] Text messageText;
  void Start()
  {
    ShowMessage("あなたのターンです");
  }

  public void ShowMessage(string message)
  {
    panel.SetActive(false); // trueにする
    messageText.text = message;
  }

  public void HideMessage()
  {
    panel.SetActive(false);
  }
}
