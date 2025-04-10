namespace SimulationGame;

/// <summary>
/// Determines whether a location should be open or not at a given time.
/// </summary>
public class ScheduleManager
{
    private readonly uint opensAt;
    private readonly uint closesAt;
    private bool isOpen;
    
    public ScheduleManager(uint opensAt, uint closesAt)
    {
        this.opensAt = opensAt;
        this.closesAt = closesAt;
    }

    public void AdvanceTime(uint currentTime)
    {
        isOpen = (currentTime % MINUTES_PER_DAY) >= opensAt && 
                 (currentTime % MINUTES_PER_DAY) <= closesAt;
    }
    
    public bool IsOpen() { return isOpen; }
    
    public const uint MINUTES_PER_DAY = 60 * 24;
}