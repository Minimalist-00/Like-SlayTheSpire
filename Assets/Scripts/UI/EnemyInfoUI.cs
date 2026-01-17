using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class EnemyInfoUI : MonoBehaviour
{
  [SerializeField] Text hpText;
  EnemyObj enemy;
  public void SetEnemy(EnemyObj enemy)
  {
    this.enemy = enemy;
  }
  void Update()
  {
    hpText.text = $"HP: {enemy.Hp}";
  }
}
