//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial interface IViewEntity {

    Code.ViewComponent view { get; }
    bool hasView { get; }

    void AddView(UnityEngine.GameObject newValue);
    void ReplaceView(UnityEngine.GameObject newValue);
    void RemoveView();
}
