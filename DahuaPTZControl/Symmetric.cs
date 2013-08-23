using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

public class Symmetric
{
	protected ASCIIEncoding enc;
	protected RijndaelManaged aesAlg;
	protected ICryptoTransform encryptor;

	protected ICryptoTransform decryptor;
	protected string password;
	public Symmetric()
	{
		password = NewRandomPassword(64);
		Initialize(password);
	}

	public Symmetric(string password)
	{
		this.password = password;
		Initialize(password);
	}

	private void Initialize(string password)
	{
		enc = new ASCIIEncoding();
		aesAlg = new RijndaelManaged();
		SHA384Managed sha = new SHA384Managed();
		byte[] shaHash = sha.ComputeHash(enc.GetBytes(password));
		byte[] Key = new byte[32];
		byte[] InitVector = new byte[16];
		Array.Copy(shaHash, 0, Key, 0, 32);
		Array.Copy(shaHash, 32, InitVector, 0, 16);
		encryptor = aesAlg.CreateEncryptor(Key, InitVector);
		decryptor = aesAlg.CreateDecryptor(Key, InitVector);
	}
	~Symmetric()
	{
		if (aesAlg != null)
			aesAlg.Clear();
	}
	protected string NewRandomPassword(int length)
	{
		StringBuilder sb = new StringBuilder(length);
		Random rand = new Random();
		for (int i = 0; i < length; i++)
		{
			sb.Append((char)rand.Next(0, 128));
		}
		return sb.ToString();
	}
	public string GetPassword()
	{
		return password;
	}
	public byte[] GetPasswordBytes()
	{
		string asString = GetPassword();
		byte[] asBytes = ASCIIEncoding.ASCII.GetBytes(asString);
		return asBytes;
	}
	public string Encrypt(string plainText)
	{
		byte[] data = enc.GetBytes(plainText);
		Encrypt(ref data);
		return Convert.ToBase64String(data);
	}
	public string Decrypt(string cipherText)
	{
		byte[] data = Convert.FromBase64String(cipherText);
		Decrypt(ref data);
		return enc.GetString(data);
	}
	public void Encrypt(ref byte[] data)
	{
		MemoryStream mStream = new MemoryStream();
		try
		{
			using (CryptoStream csEncrypt = new CryptoStream(mStream, encryptor, CryptoStreamMode.Write))
			{
				int i = 0;
				int writeLength = Math.Min(data.Length, 10000);
				while (i < data.Length)
				{
					csEncrypt.Write(data, i, writeLength);
					i += writeLength;
					writeLength = Math.Min(data.Length - i, 10000);
					if (writeLength <= 0)
						break;
				}
				csEncrypt.Flush();
				csEncrypt.FlushFinalBlock();
				csEncrypt.Close();
				data = mStream.ToArray();
			}
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine("A symmetric encryption error has occurred:" + Environment.NewLine + ex.Message);
		}
		finally
		{
			mStream.Close();
		}
	}

	public void Decrypt(ref byte[] data)
	{
		MemoryStream mStream = new MemoryStream(data);
		MemoryStream outputStream = new MemoryStream();
		try
		{
			using (CryptoStream csDecrypt = new CryptoStream(mStream, decryptor, CryptoStreamMode.Read))
			{
				byte[] buffer = new byte[10000];
				int bytes = csDecrypt.Read(buffer, 0, 10000);
				while (bytes > 0)
				{
					outputStream.Write(buffer, 0, bytes);
					bytes = csDecrypt.Read(buffer, 0, 10000);
				}
				csDecrypt.Close();
				data = outputStream.ToArray();
			}
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine("A symmetric decryption error has occurred:" + Environment.NewLine + ex.Message);
		}
		finally
		{
			mStream.Close();
			outputStream.Close();
		}
		return;
	}
}