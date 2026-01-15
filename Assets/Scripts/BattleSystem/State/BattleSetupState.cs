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

    foreach (var card in Owner.Deck.CardList)
    {
      card.OnUseAction += CardMoveToDiscardArea;
    }

    // StateをPlayerDrawStateに変更する
    // Owner(BattleSetupState)のChangeStateメソッドを呼び出す。そしてPlayerDrawStateプロパティを引数として渡す
    Owner.ChangeState(Owner.PlayerDrawState);
  }

  void CardMoveToDiscardArea(CardObj card)
  {
    Owner.Hand.RemoveCard(card);
    Owner.DiscardArea.AddCard(card);
  }
}
