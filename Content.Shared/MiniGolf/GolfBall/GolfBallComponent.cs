using Robust.Shared.Audio;
using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.MiniGolf.GolfBall;

[RegisterComponent, NetworkedComponent, Access(typeof(SharedGolfBallSystem))]
public sealed partial class GolfBallComponent : Component
{
    [DataField("sound")]
    public SoundSpecifier Sound { get; private set; } = new SoundCollectionSpecifier("Dice");
}
