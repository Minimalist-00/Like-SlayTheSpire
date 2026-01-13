using UnityEngine;
using System.Collections.Generic;

public class EnemyManager : MonoBehaviour
{
  List<EnemyObj> list = new List<EnemyObj>();

  public void AddEnemy(EnemyObj enemy)
  {
    list.Add(enemy);
  }
  
}
