using System;

public class NFT
{
    public string Id { get; private set; }
    public string Owner { get; private set; }
    public Item Item { get; private set; }

    public NFT(string id, string owner, Item item)
    {
        if (string.IsNullOrEmpty(id) || id.Length > 100)
        {
            throw new ArgumentException("Invalid id", nameof(id));
        }

        if (string.IsNullOrEmpty(owner) || owner.Length > 100)
        {
            throw new ArgumentException("Invalid owner", nameof(owner));
        }

        if (item == null)
        {
            throw new ArgumentException("Invalid item", nameof(item));
        }

        Id = id;
        Owner = owner;
        Item = item;
    }
}
