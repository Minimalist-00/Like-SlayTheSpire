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
  public override void OnExit()
  {
    Debug.Log("Battle Card Sellection State Exit");
    // 手札のカードを全て捨て札に入れる
    Owner.Hand.DiscardAllCards(Owner.DiscardArea);
  }
}
