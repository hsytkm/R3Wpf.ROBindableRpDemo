# R3 Issue Demo

[Cysharp/R3: The new future of dotnet/reactive and UniRx.](https://github.com/Cysharp/R3)





---

## Title

Able to write values to `IReadOnlyBindableReactiveProperty<T>`

## Issue
It is possible to write values to `IReadOnlyBindableReactiveProperty<T>`, which should be read-only.

## Details
While the `Value` property does not have a setter in C# code, preventing direct modification, binding from XAML (e.g., to `ListView.SelectedItem`) still results in the value being set.

Additional Information
In `runceel/ReactiveProperty`, a `System.Windows.Markup.XamlParseException` occurs immediately after execution.

## Environment
- Visual Studio 2022 17.11.0
- .NET8
- WPF
- R3Extensions.WPF 1.2.5

## Repository
