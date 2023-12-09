using System;
using System.Collections.Generic;

public class Main
{
    public static void Main(string[] args)
    {
        // Create some items
        Item sword = new Item("Sword", "Silver", "Large");
        Item shield = new Item("Shield", "Gold", "Medium");

        List<Item> items = new List<Item> {sword, shield};

        // Generate NFTs for the items
        List<NFT> nfts = NFTGenerator.GenerateNFTs(items, "Player1");

        // Create an ownership verifier
        OwnershipVerifier ownershipVerifier = new OwnershipVerifier(nfts);

        // Verify the ownership of the first NFT
        string owner = ownershipVerifier.VerifyOwnership(nfts[0].Id);

        Console.WriteLine($"The owner of the NFT with id {nfts[0].Id} is {owner}");
    }
}
