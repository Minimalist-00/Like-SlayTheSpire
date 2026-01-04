using UnityEngine;

public class BattleSystem : MonoBehaviour
{

  // フェーズ（バトルの状態）の管理
  // ・1.準備：setup：Deckを作る
  // ・2.Playerのドローフェーズ:Deckからカードを5枚引く
  // ・3.Playerのカード選択のフェーズ
  // ・4.Playerのカード効果のフェーズ
  // ・5.Enemyのフェーズ

  // これらをステートパターンで管理する
  // 利点：各フェーズの処理がクラスに分かれているので、編集がしやすい

  // どうやって実装するの？
  // ・状態の基底クラスを作る
  // ・それぞれのクラスを作る
  // ・状態の切り替えを行う関数を作る

  // 状態管理の変数をつくる
  BattleStateBase currentState;
  BattleSetupState setupState;
  BattlePlayerDrawState playerDrawState;
  BattleCardSellectionState cardSellectionState;

  // 外部からplayerDrawState変数を参照できるようにするプロパティを作る（Read-Only）
  public BattlePlayerDrawState PlayerDrawState => playerDrawState;

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
