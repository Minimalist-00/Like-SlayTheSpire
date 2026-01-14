using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{

  // 状態管理の変数をつくる
  BattleStateBase currentState;
  BattleSetupState setupState;
  BattlePlayerDrawState playerDrawState;
  BattleCardSellectionState cardSellectionState;
  BattleEnemyTurnState enemyTurnState;

  [SerializeField] Deck deck;
  [SerializeField] Hand hand;
  [SerializeField] EnemyGenerator enemyGenerator;

  // 外部から参照できるようにするプロパティを作る（Read-Only）
  public Deck Deck => deck;
  public Hand Hand => hand;
  public EnemyGenerator EnemyGenerator => enemyGenerator;
  public BattleCardSellectionState CardSellectionState => cardSellectionState;
  public BattlePlayerDrawState PlayerDrawState => playerDrawState;
  public BattleEnemyTurnState EnemyTurnState => enemyTurnState;

  void Start()
  {
    Debug.Log("Battle System Start");
    // 各状態のインスタンスを作成する
    setupState = new BattleSetupState(this);
    playerDrawState = new BattlePlayerDrawState(this);
    cardSellectionState = new BattleCardSellectionState(this);
    enemyTurnState = new BattleEnemyTurnState(this);

    ChangeState(setupState);
  }

  // 状態の切り替え
  public void ChangeState(BattleStateBase newState)
  {
    if (currentState != null)
    {
      currentState.OnExit();
    }
    currentState = newState;
    currentState.OnEnter();
  }

  void Update()
  {
    currentState.OnUpdate();
  }

  public void OnTurnEndButton()
  {
    // 敵のターンに移行する
    ChangeState(enemyTurnState);
  }

}
