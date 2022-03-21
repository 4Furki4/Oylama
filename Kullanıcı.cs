using System.Collections.Generic;

namespace Oylama
{
    public class Kullanıcı
    {
        private string username;

        public string Username { get => username; set => username = value; }

        public Kullanıcı(string username)
        {
            Username = username;
        }

        public void KullanıcıKaydet(List<Kullanıcı> list,string username)
        {
            
            list.Add(new Kullanıcı(username));
        }
    }
}