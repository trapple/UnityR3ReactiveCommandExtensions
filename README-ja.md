# Unity R3 ReactiveCommand Extensions

Unity向けのR3用ReactiveCommand拡張メソッドを提供するライブラリです。

## 概要

このライブラリは、R3のReactiveCommandに対して便利な拡張メソッドを追加します。現在、`TryExecute`メソッドを提供しており、コマンドが実行可能な場合のみ実行を試みる安全な実行方法を提供します。

## 機能

### TryExecute

`TryExecute`メソッドは、ReactiveCommandが実行可能（`CanExecute()`がtrueを返す）な場合のみコマンドを実行します。

## 使用例

```csharp
using R3;
using UnityEngine;
using R3.Unity.ReactiveCommandExtensions;

public class Sample : MonoBehaviour
{
    private void Start()
    {
        ReactiveProperty<bool> gate = new(false);
        var command = gate.ToReactiveCommand<string>();
        command.Subscribe(Debug.Log);

        gate.Value = true;
        command.TryExecute("gate is true, from TryExecute"); // 実行される

        gate.Value = false;
        command.TryExecute("gate is false, from TryExecute"); // 実行されない（falseを返す）
    }
}
```

## インストール

### Unity Package Manager経由

```
https://github.com/trapple/UnityR3ReactiveCommandExtensions.git?path=Assets/R3.Unity.ReactiveCommandExtensions
```
## ライセンス

MIT License
