using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoUI : MonoBehaviour
{
  [SerializeField] PlayerObj player;
  [SerializeField] Text hpText;
  [SerializeField] Text defenseText;

  void Update()
  {
    hpText.text = $"HP: {player.Hp}";
    defenseText.text = $"Defense: {player.Defense}";
  }
}
