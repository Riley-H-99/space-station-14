using Content.Shared.Examine;

namespace Content.Shared.MiniGolf.GolfBall;

public abstract class SharedGolfBallSystem : EntitySystem
{
    /// <summary>
    /// If an attack is released within this buffer it's assumed to be full damage.
    /// </summary>
    public const float GracePeriod = 0.05f;

    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<GolfBallComponent, ExaminedEvent>(OnExamined);
    }

    private void OnExamined(EntityUid uid, GolfBallComponent component, ExaminedEvent args)
    {
        throw new NotImplementedException();
    }
}
