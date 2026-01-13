using UnityEngine;

public class BattleSetupState : BattleStateBase
{
  public BattleSetupState(BattleSystem battleSystem) : base(battleSystem)
  {
  }

  public override void OnEnter()
  {
    // 先にDeckを初期化
    Owner.Deck.Setup();
    Owner.EnemyGenerator.Setup();

    // StateをPlayerDrawStateに変更する
    // Owner(BattleSetupState)のChangeStateメソッドを呼び出す。そしてPlayerDrawStateプロパティを引数として渡す
    Owner.ChangeState(Owner.PlayerDrawState);
  }
}
