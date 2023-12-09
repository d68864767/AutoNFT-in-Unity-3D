using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

public class NFTGenerator
{
    private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

    public static List<NFT> GenerateNFTs(List<Item> items, string owner)
    {
        List<NFT> nfts = new List<NFT>();

        foreach (var item in items)
        {
            string id = GenerateUniqueIdentifier(item);
            nfts.Add(new NFT(id, owner, item));
        }

        return nfts;
    }

    private static string GenerateUniqueIdentifier(Item item)
    {
        string input = $"{item.Type}{item.Color}{item.Size}{DateTime.Now.Ticks}";
        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        byte[] hashBytes;

        using (SHA256 sha256 = SHA256.Create())
        {
            hashBytes = sha256.ComputeHash(inputBytes);
        }

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < hashBytes.Length; i++)
        {
            sb.Append(hashBytes[i].ToString("X2"));
        }

        return sb.ToString();
    }
}
