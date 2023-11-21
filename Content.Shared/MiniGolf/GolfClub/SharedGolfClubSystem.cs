using Content.Shared.Examine;

namespace Content.Shared.MiniGolf.GolfClub;

public abstract class SharedGolfClubSystem : EntitySystem
{
    /// <summary>
    /// If an attack is released within this buffer it's assumed to be full damage.
    /// </summary>
    public const float GracePeriod = 0.05f;

    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<GolfClubComponent, ExaminedEvent>(OnExamined);
    }

    private void OnExamined(EntityUid uid, GolfClubComponent component, ExaminedEvent args)
    {
        throw new NotImplementedException();
    }
}
