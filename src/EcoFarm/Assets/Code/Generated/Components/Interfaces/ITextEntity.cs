//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial interface ITextEntity {

    Code.TextComponent text { get; }
    bool hasText { get; }

    void AddText(string newValue);
    void ReplaceText(string newValue);
    void RemoveText();
}
