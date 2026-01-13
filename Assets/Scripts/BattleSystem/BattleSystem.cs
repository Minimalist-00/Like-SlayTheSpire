using UnityEngine;

public class BattleSystem : MonoBehaviour
{

  // 状態管理の変数をつくる
  BattleStateBase currentState;
  BattleSetupState setupState;
  BattlePlayerDrawState playerDrawState;
  BattleCardSellectionState cardSellectionState;

  [SerializeField] Deck deck;
  [SerializeField] Hand hand;
  [SerializeField] EnemyGenerator enemyGenerator; 

  // 外部から参照できるようにするプロパティを作る（Read-Only）
  public BattlePlayerDrawState PlayerDrawState => playerDrawState;
  public Deck Deck => deck;
  public Hand Hand => hand;
  public EnemyGenerator EnemyGenerator => enemyGenerator;

  void Start()
  {
    Debug.Log("Battle System Start");
    // 各状態のインスタンスを作成する
    setupState = new BattleSetupState(this);
    playerDrawState = new BattlePlayerDrawState(this);
    cardSellectionState = new BattleCardSellectionState(this);

    ChangeState(setupState);
  }

  // 状態の切り替え
  public void ChangeState(BattleStateBase newState)
  {
    currentState = newState;
    currentState.OnEnter();
  }

}
