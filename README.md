# Unity R3 ReactiveCommand Extensions

A library that provides ReactiveCommand extension methods for R3 in Unity.

## Overview

This library adds convenient extension methods to R3's ReactiveCommand. Currently, it provides a `TryExecute` method that offers a safe way to execute commands only when they are executable.

## Features

### TryExecute

The `TryExecute` method executes a ReactiveCommand only when it is executable (when `CanExecute()` returns true).

## Usage Example

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
        command.TryExecute("gate is true, from TryExecute"); // Executed

        gate.Value = false;
        command.TryExecute("gate is false, from TryExecute"); // Not executed (returns false)
    }
}
```

## Installation

### Via Unity Package Manager

```
https://github.com/trapple/UnityR3ReactiveCommandExtensions.git?path=Assets/R3.Unity.ReactiveCommandExtensions
```

## License

MIT License