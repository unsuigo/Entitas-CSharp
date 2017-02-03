//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public JaggedArrayComponent jaggedArray { get { return (JaggedArrayComponent)GetComponent(GameComponentsLookup.JaggedArray); } }
    public bool hasJaggedArray { get { return HasComponent(GameComponentsLookup.JaggedArray); } }

    public void AddJaggedArray(string[][] newJaggedArray) {
        var component = CreateComponent<JaggedArrayComponent>(GameComponentsLookup.JaggedArray);
        component.jaggedArray = newJaggedArray;
        AddComponent(GameComponentsLookup.JaggedArray, component);
    }

    public void ReplaceJaggedArray(string[][] newJaggedArray) {
        var component = CreateComponent<JaggedArrayComponent>(GameComponentsLookup.JaggedArray);
        component.jaggedArray = newJaggedArray;
        ReplaceComponent(GameComponentsLookup.JaggedArray, component);
    }

    public void RemoveJaggedArray() {
        RemoveComponent(GameComponentsLookup.JaggedArray);
    }
}