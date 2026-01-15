using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObj : MonoBehaviour
{
  [SerializeField] int hp;

  public int HP => hp;

  public void Damage(int damage)
  {
    hp -= damage;
    if (hp <= 0)
    {
      // TODO: Game Over
      Debug.Log("Game Over");
    }
  }
}
