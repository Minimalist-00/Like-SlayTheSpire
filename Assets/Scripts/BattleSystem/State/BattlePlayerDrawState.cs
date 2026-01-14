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
      // Deckにカードがないとき、捨て札のカードを移動する
      if (Owner.Deck.IsEmpty)
      {
        Owner.DiscardArea.ReturnCardsToDeck(Owner.Deck);
      }

      CardObj drawCard = Owner.Deck.DrawCard();
      // Handにカードを渡す
      Owner.Hand.AddCard(drawCard);
    }
    Owner.ChangeState(Owner.CardSellectionState);
  }
}
