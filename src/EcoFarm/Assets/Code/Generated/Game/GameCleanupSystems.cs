//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.Roslyn.CodeGeneration.Plugins.CleanupSystemsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class GameCleanupSystems : Feature {

    public GameCleanupSystems(Contexts contexts) {
        Add(new RemoveUsedGameSystem(contexts));
        Add(new RemoveRenewGameSystem(contexts));
        Add(new DestroyMouseClickGameSystem(contexts));
        Add(new RemoveMouseDownGameSystem(contexts));
        Add(new RemoveMouseUpGameSystem(contexts));
        Add(new RemoveButtonClickGameSystem(contexts));
        Add(new RemovePollutionCoefficientGameSystem(contexts));
        Add(new RemovePollutionGameSystem(contexts));
        Add(new RemoveWateredGameSystem(contexts));
        Add(new RemoveDurationUpGameSystem(contexts));
        Add(new DestroyDestroyGameSystem(contexts));
        Add(new RemovePickedGameSystem(contexts));
    }
}
