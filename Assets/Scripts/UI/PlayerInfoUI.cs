using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInfoUI : MonoBehaviour
{
  [SerializeField] PlayerObj player;
  [SerializeField] TextMeshProUGUI hpText;
  [SerializeField] TextMeshProUGUI defenseText;

  void Update()
  {
    hpText.text = $"HP: {player.Hp}";
    defenseText.text = $"Defense: {player.Defense}";
  }
}
