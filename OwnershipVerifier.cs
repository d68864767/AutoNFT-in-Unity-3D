using System;
using System.Collections.Generic;

public class OwnershipVerifier
{
    private Dictionary<string, NFT> nftDictionary;

    public OwnershipVerifier(List<NFT> nfts)
    {
        if (nfts == null)
        {
            throw new ArgumentException("Invalid NFT list", nameof(nfts));
        }

        nftDictionary = new Dictionary<string, NFT>();

        foreach (var nft in nfts)
        {
            if (!nftDictionary.ContainsKey(nft.Id))
            {
                nftDictionary.Add(nft.Id, nft);
            }
            else
            {
                throw new ArgumentException("Duplicate NFT id", nameof(nft.Id));
            }
        }
    }

    public string VerifyOwnership(string id)
    {
        if (string.IsNullOrEmpty(id) || id.Length > 100)
        {
            throw new ArgumentException("Invalid id", nameof(id));
        }

        if (!nftDictionary.ContainsKey(id))
        {
            throw new ArgumentException("NFT not found", nameof(id));
        }

        return nftDictionary[id].Owner;
    }
}
