using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 状態の基底クラス
public class BattleStateBase // MonoBehaviourを継承しない = Unityの性質がない
{
  // 誰の状態か: BattleSystemの状態を考える
  protected BattleSystem Owner;

  // コンストラクタ: 初期化処理として生成時によばれる（誰の状態かを受け取る）
  public BattleStateBase(BattleSystem owner)
  {
    Owner = owner;
  }

  // その状態になった時に呼ばれる
  public virtual void OnEnter()
  {

  }

  // その状態の毎フレームの更新処理
  public virtual void OnUpdate()
  {

  }

  // その状態から抜ける時に呼ばれる
  public virtual void OnExit()
  {

  }
}
