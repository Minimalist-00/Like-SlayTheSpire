using UnityEngine;

public class BattleCardSellectionState : BattleStateBase
{
  public BattleCardSellectionState(BattleSystem battleSystem) : base(battleSystem)
  {
  }

  public override void OnEnter()
  {
    Debug.Log("Battle Card Sellection State");
  }
}
