using Library.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Context
    {
        Enc enc;
        public Context()
        {
            enc = new Enc();
        }
        public List<Books> books()
        {
            //if (File.Exists("dbBooks.txt"))
            //{
            //    List<Books> db = new List<Books>();
            //    db = JsonConvert.DeserializeObject<List<Books>>(enc.DecryptFile("dbBooks.txt"));

            //    return db;
            //}
            //return null;
            if (File.Exists("dbBooks.json"))
            {
                List<Books> db = new List<Books>();
                JsonSerializer serializer = new JsonSerializer();

                using (var sw = new StreamReader("dbBooks.json"))
                using (var reader = new JsonTextReader(sw))
                {
                    db = serializer.Deserialize(reader, typeof(List<Books>)) as List<Books>;
                }
                return db;
            }
            return null;
        }
        public void SaveChangesForBooks(List<Books> books)
        {
            //var serializer = new JsonSerializer();
            //try
            //{
            //    string json = JsonConvert.SerializeObject(books, Formatting.Indented);
            //    File.WriteAllText("dbBooks.txt",enc.EncryptFile(json));
            //}

            //catch (JsonSerializationException)
            //{
            //    //System.Console.WriteLine("Indeed, it was {0}");
            //}
            var serializer = new JsonSerializer();
            try
            {
                string json = JsonConvert.SerializeObject(books, Formatting.Indented);
                File.WriteAllText("dbBooks.json", json);
            }

            catch (JsonSerializationException)
            {
                //System.Console.WriteLine("Indeed, it was {0}");
            }
        }
        public List<Members> members()
        {
            if (File.Exists("dbMembers.json"))
            {
                List<Members> db = new List<Members>();
                JsonSerializer serializer = new JsonSerializer();

                using (var sw = new StreamReader("dbMembers.json"))
                using (var reader = new JsonTextReader(sw))
                {
                    db = serializer.Deserialize(reader, typeof(List<Members>)) as List<Members>;
                }
                return db;
            }
            return null;
        }
        public void SaveChangesForMembers(List<Members> members)
        {
            var serializer = new JsonSerializer();
            try
            {
                string json = JsonConvert.SerializeObject(members, Formatting.Indented);
                File.WriteAllText("dbMembers.json", json);
            }

            catch (JsonSerializationException)
            {
                //System.Console.WriteLine("Indeed, it was {0}");
            }
        }
        public List<Users> users()
        {
            //if (File.Exists("dbUsers.json"))
            //{
            //    List<Users> db = new List<Users>();
            //    JsonSerializer serializer = new JsonSerializer();

            //    using (var sw = new StreamReader("dbUsers.json"))
            //    using (var reader = new JsonTextReader(sw))
            //    {
            //        db = serializer.Deserialize(reader, typeof(List<Users>)) as List<Users>;
            //    }
            //    return db;
            //}
            //return null;
            if (File.Exists("dbUsers.json"))
            {
                List<Users> db = new List<Users>();
                JsonSerializer serializer = new JsonSerializer();

                using (var sw = new StreamReader("dbUsers.json"))
                using (var reader = new JsonTextReader(sw))
                {
                    db = serializer.Deserialize(reader, typeof(List<Users>)) as List<Users>;
                }
                return db;
            }
            return null;

        }
        public void SaveChangesForMembers(List<Users> users)
        {
            //var serializer = new JsonSerializer();
            //try
            //{
            //    string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            //    File.WriteAllText("dbUsers.json", json);
            //}

            //catch (JsonSerializationException)
            //{
            //    //System.Console.WriteLine("Indeed, it was {0}");
            //}
            var serializer = new JsonSerializer();
            try
            {
                string json = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText("dbUsers.json", json);
            }

            catch (JsonSerializationException)
            {
                //System.Console.WriteLine("Indeed, it was {0}");
            }
        }
        public List<Reservations> reservations()
        {
            //if (File.Exists("dbReservations.txt"))
            //{
            //    List<Reservations> db = new List<Reservations>();
            //    db = JsonConvert.DeserializeObject<List<Reservations>>(enc.DecryptFile("dbReservations.txt"));

            //    return db;
            //}
            //return null;
            if (File.Exists("dbReservations.json"))
            {
                List<Reservations> db = new List<Reservations>();
                JsonSerializer serializer = new JsonSerializer();

                using (var sw = new StreamReader("dbReservations.json"))
                using (var reader = new JsonTextReader(sw))
                {
                    db = serializer.Deserialize(reader, typeof(List<Reservations>)) as List<Reservations>;
                }
                return db;
            }
            return null;
        }
        public void SaveChangesForReservations(List<Reservations> reservations)
        {
            //var serializer = new JsonSerializer();
            //try
            //{
            //    string json = JsonConvert.SerializeObject(reservations, Formatting.Indented);
            //    File.WriteAllText("dbReservations.txt", enc.EncryptFile(json));
            //}

            //catch (JsonSerializationException)
            //{
            //    //System.Console.WriteLine("Indeed, it was {0}");
            //}
            var serializer = new JsonSerializer();
            try
            {
                string json = JsonConvert.SerializeObject(reservations, Formatting.Indented);
                File.WriteAllText("dbReservations.json", json);
            }

            catch (JsonSerializationException)
            {
                //System.Console.WriteLine("Indeed, it was {0}");
            }
        }
        public List<Borrowed> borroweds()
        {
            //if (File.Exists("dbBorrowed.txt"))
            //{
            //    List<Borrowed> db = new List<Borrowed>();
            //    db = JsonConvert.DeserializeObject<List<Borrowed>>(enc.DecryptFile("dbBorrowed.txt"));

            //    return db;
            //}
            //return null;
            if (File.Exists("dbBorrowed.json"))
            {
                List<Borrowed> db = new List<Borrowed>();
                JsonSerializer serializer = new JsonSerializer();

                using (var sw = new StreamReader("dbBorrowed.json"))
                using (var reader = new JsonTextReader(sw))
                {
                    db = serializer.Deserialize(reader, typeof(List<Borrowed>)) as List<Borrowed>;
                }
                return db;
            }
            return null;
        }
        public void SaveChangesForBorroweds(List<Borrowed> borroweds)
        {
            //var serializer = new JsonSerializer();
            //try
            //{
            //    string json = JsonConvert.SerializeObject(borroweds, Formatting.Indented);
            //    File.WriteAllText("dbBorrowed.txt", enc.EncryptFile(json));
            //}

            //catch (JsonSerializationException)
            //{
            //    //System.Console.WriteLine("Indeed, it was {0}");
            //}
            var serializer = new JsonSerializer();
            try
            {
                string json = JsonConvert.SerializeObject(borroweds, Formatting.Indented);
                File.WriteAllText("dbBorrowed.json", json);
            }

            catch (JsonSerializationException)
            {
                //System.Console.WriteLine("Indeed, it was {0}");
            }
        }
    }
    class Enc
    {
        private readonly string key = "123456";
        public string EncryptFile(string json)
        {
            return Encryptor(json, key);
        }
        public string DecryptFile(string PathFile)
        {
            string cipherText = File.ReadAllText(PathFile);
            return Decryptor(cipherText, key);
        }
        static string Encryptor(string cleantext, string key)
        {
            PasswordDeriveBytes passwordivebyte = new PasswordDeriveBytes(Encoding.UTF8.GetBytes(key),
            new byte[] { 0x10, 0x65, 0x55, 0x44, 0x33, 0x25 });
            MemoryStream ms = new MemoryStream();
            Rijndael rijndeal = Rijndael.Create();
            rijndeal.Key = passwordivebyte.GetBytes(32);
            rijndeal.IV = passwordivebyte.GetBytes(16);
            CryptoStream cs = new CryptoStream(ms, rijndeal.CreateEncryptor(), CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cs);
            sw.Write(cleantext);
            sw.Flush();
            sw.Close();
            byte[] end = ms.ToArray();
            return Convert.ToBase64String(end);
        }
        static string Decryptor(string EncrptText, string key)
        {
            string text;
            try
            {
                PasswordDeriveBytes passwordivebyte = new PasswordDeriveBytes(Encoding.UTF8.GetBytes(key),
                new byte[] { 0x10, 0x65, 0x55, 0x44, 0x33, 0x25 });
                MemoryStream MS = new MemoryStream(Convert.FromBase64String(EncrptText));
                Rijndael rg = Rijndael.Create();
                rg.Key = passwordivebyte.GetBytes(32);
                rg.IV = passwordivebyte.GetBytes(16);
                CryptoStream CS = new CryptoStream(MS, rg.CreateDecryptor(), CryptoStreamMode.Read);
                StreamReader sr = new StreamReader(CS);
                text = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception)
            {
                text = "";
            }
            return text;
        }
    }
    
}