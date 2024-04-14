using System;
using System.Collections.Generic;
using DataProvider.Models;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

namespace DataProvider.DataRepo
{
    public class DataServiceImpl : DataService
    {
        private const string _encryptionKey = "test2"; 

        public IList<Skill> GetSkills(string dataSet)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "MetaData", "skills_"+dataSet+".json");

            if (string.IsNullOrEmpty(filePath))
            {
                return new List<Skill>();
            }

            return (File.Exists(filePath)
                ? JsonConvert.DeserializeObject<IList<Skill>>(Decrypt(File.ReadAllText(filePath), _encryptionKey))
                : new List<Skill>()) ?? new List<Skill>(); 
        }

        public IList<Entity> GetEntities(string dataSet)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "MetaData", "entities_"+dataSet+".json");

            if (string.IsNullOrEmpty(filePath))
            {
                return new List<Entity>();
            }

            return (File.Exists(filePath)
                ? JsonConvert.DeserializeObject<IList<Entity>>(Decrypt(File.ReadAllText(filePath), _encryptionKey))
                : new List<Entity>()) ?? new List<Entity>(); 
        }

        public void UpdateSkills(IList<Skill> skills, string dataSet)
        {
            
            string json = JsonConvert.SerializeObject(skills);
            string encryptedJson = Encrypt(json, _encryptionKey);
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string directoryPath = Path.Combine(desktopPath, "MetaData");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, "skills_"+dataSet+".json"), encryptedJson);
        }

        public void UpdateEnitties(IList<Entity> entities, string dataSet)
        {
            string json = JsonConvert.SerializeObject(entities);
            string encryptedJson = Encrypt(json, _encryptionKey);
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string directoryPath = Path.Combine(desktopPath, "MetaData");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, "entities_"+dataSet+".json"), encryptedJson);
        }

        public IList<string> GetDataSets()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "MetaData", "DataSets.json");
            if (string.IsNullOrEmpty(filePath))
            {
                return new List<string>();
            }
            return (File.Exists(filePath)
                ? JsonConvert.DeserializeObject<IList<string>>(File.ReadAllText(filePath))
                : new List<string>()) ?? new List<string>();
        }

        public void UpdateDataSets(IList<string> dataSets)
        {
            string json = JsonConvert.SerializeObject(dataSets);
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string directoryPath = Path.Combine(desktopPath, "MetaData");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, "DataSets.json"), json);
        }


        private static string Encrypt(string clearText, string encryptionKey)
        {
            if (string.IsNullOrEmpty(clearText) || string.IsNullOrEmpty(encryptionKey))
            {
                return string.Empty;
            }

            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);

            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey,
                    new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65,
                                 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
        
        private static string Decrypt(string cipherText, string encryptionKey)
        {
            if (string.IsNullOrEmpty(cipherText) || string.IsNullOrEmpty(encryptionKey))
            {
                return string.Empty;
            }

            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey,
                    new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65,
                                 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    }
}