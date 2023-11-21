using Robust.Shared.GameStates;

namespace Content.Shared.MiniGolf.GolfClub;

[RegisterComponent, NetworkedComponent, Access(typeof(SharedGolfClubSystem))]
public sealed partial class GolfClubComponent : Component
{

}
