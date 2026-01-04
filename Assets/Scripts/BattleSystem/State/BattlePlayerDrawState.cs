using UnityEngine;

public class BattlePlayerDrawState : BattleStateBase
{
  public BattlePlayerDrawState(BattleSystem battleSystem) : base(battleSystem)
  {
  }

  public override void OnEnter()
  {
    Debug.Log("Battle Player Draw State");
    for (int i = 0; i < 5; i++)
    {
      CardObj drawCard = Owner.Deck.DrawCard();
      // Handにカードを渡す
      Owner.Hand.AddCard(drawCard);
    }
  }
}
