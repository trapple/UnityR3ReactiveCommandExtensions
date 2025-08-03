using R3;
using UnityEngine;
using R3.Unity.ReactiveCommandExtensions;

public class Sample : MonoBehaviour
{
    private void Start()
    {
        var gate = new ReactiveProperty<bool>(false);
        var command = gate.ToReactiveCommand<string>();
        command.Subscribe(Debug.Log);

        gate.Value = true;
        command.TryExecute("gate is true, from TryExecute");
        command.Execute("gate is true, from Execute");

        gate.Value = false;
        command.TryExecute("gate is false, from TryExecute");
        command.Execute("gate is false, from Execute");
    }
}
