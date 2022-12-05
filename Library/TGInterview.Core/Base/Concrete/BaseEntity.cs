namespace TGInterview.Core.Base.Concrete;

public abstract class BaseEntity
{
    public Guid Id { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public DateTime? DeletedDate { get; set; }
}