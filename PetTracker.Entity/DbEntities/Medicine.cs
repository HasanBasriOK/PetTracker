using PetTracker.Entity.Enums;

namespace PetTracker.Entity.DbEntities;

public class Medicine : BaseEntity
{
    public string Name { get; set; }
    public MedicineUsageReason UsageReason { get; set; }
    public string ScheduleCronEx { get; set; }
    public bool IsScheduleActive { get; set; }
} 