//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcoFarm.BucketComponent bucketComponent = new EcoFarm.BucketComponent();

    public bool isBucket {
        get { return HasComponent(GameComponentsLookup.Bucket); }
        set {
            if (value != isBucket) {
                var index = GameComponentsLookup.Bucket;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : bucketComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherBucket;

    public static Entitas.IMatcher<GameEntity> Bucket {
        get {
            if (_matcherBucket == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Bucket);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherBucket = matcher;
            }

            return _matcherBucket;
        }
    }
}
