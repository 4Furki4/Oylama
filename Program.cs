using System;
using System.Collections.Generic;

namespace Oylama
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<Kullanıcı> kullanıcılar = new List<Kullanıcı>(); // 4 tane varsayılan kullanıcı atadım.
            kullanıcılar.Add(new Kullanıcı("Furkan"));
            kullanıcılar.Add(new Kullanıcı("Betül"));
            kullanıcılar.Add(new Kullanıcı("Semiha"));
            kullanıcılar.Add(new Kullanıcı("Aybüke"));
        }
    }
}
