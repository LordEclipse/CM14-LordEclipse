using Robust.Shared.GameStates;

namespace Content.Shared._RMC14.Deafness;

[Access(typeof(SharedDeafnessSystem))]
[RegisterComponent, NetworkedComponent]
public sealed partial class DeafenWhileCritComponent : Component;
