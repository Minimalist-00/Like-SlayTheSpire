using UnityEngine;

public class BattleEnemyTurnState : BattleStateBase
{
  public BattleEnemyTurnState(BattleSystem battleSystem) : base(battleSystem)
  {
  }

  public override void OnEnter()
  {
    // Enemyの行動
    Debug.Log("Battle Enemy Turn State");

    // Playerのターンに戻る
    Owner.ChangeState(Owner.PlayerDrawState);
  }
}
