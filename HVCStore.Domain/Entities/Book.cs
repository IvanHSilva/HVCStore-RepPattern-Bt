using HVCStore.Domain.Abstractions;

namespace HVCStore.Domain.Entities;

public class Book : Entity
{
    public string Title { get; set; } = string.Empty;
}