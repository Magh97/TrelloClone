namespace TrelloClone.Domain.Entities;

public enum ActivityActionType
{
    Created,
    Updated,
    Deleted,
    Moved,
    Commented,
    AddedMember,
    RemovedMember,
    AddedLabel,
    RemovedLabel,
    AddedAttachment,
    RemovedAttachment,
    None
}