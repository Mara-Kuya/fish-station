using Robust.Shared.Prototypes;

namespace Content.Shared._Fish.GhostRoles.Components;

/// <summary>
/// Маркер ghost role, который спавнит собственного персонажа игрока из профиля (1 слот).
/// </summary>
[RegisterComponent, EntityCategory("Spawner")]
public sealed partial class GhostRoleProfileSpawnerComponent : Component;
