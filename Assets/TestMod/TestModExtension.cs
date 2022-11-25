using IOrrstead;
using UnityEngine;

public class TestModExtension : GameExtensionBase {
    public override void OnAfterLevelLoaded(LoadMode mode) {
        Debug.Log("Test mod loaded");
    }
}
