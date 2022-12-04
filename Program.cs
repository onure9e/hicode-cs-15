using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace string_methods

{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> sayiliste = new List<int>{};

            sayiliste.Add(1);   
            sayiliste.Add(2); 
            sayiliste.Add(3); 
            sayiliste.Add(4); 
            sayiliste.Add(5); 
            sayiliste.Add(6); 
            sayiliste.Add(7); 
            sayiliste.Add(8);
            sayiliste.Add(9);  

            List<string> renkliste = new List<string>{};

            renkliste.Add("Kırmızı");
            renkliste.Add("Mavi");
            renkliste.Add("Yeşil");
            renkliste.Add("Sarı");
            renkliste.Add("Turuncu");
            renkliste.Add("Mor");

            System.Console.WriteLine(sayiliste.Count);
            System.Console.WriteLine(renkliste.Count);

            foreach (var n in sayiliste)
            {
                System.Console.WriteLine(n);
            }
            foreach (var n in renkliste)
            {
                System.Console.WriteLine(n);
            }

            sayiliste.ForEach(sayi=>{ System.Console.WriteLine(sayi);});
            renkliste.ForEach(renk=>{ System.Console.WriteLine(renk);});

            sayiliste.Remove(4);
            renkliste.Remove("Yeşil");
            
            sayiliste.ForEach(sayi=>{ System.Console.WriteLine(sayi);});
            renkliste.ForEach(renk=>{ System.Console.WriteLine(renk);});

            if(sayiliste.Contains(10)){
                System.Console.WriteLine("10 liste de bulundu");
            }else{
                System.Console.WriteLine("Sayıda 10 bulunamadı");
            }

            System.Console.WriteLine(renkliste.BinarySearch("Sarı"));

            string[] hayvanlar = {"Kedi","Köpek","Kuş","Tavşan"};

            List<string> hayvanlistesi = new List<string>(hayvanlar);

            hayvanlistesi.Clear();

            List<Kullanıcılar> kullanıcılistesi = new List<Kullanıcılar>{};

            Kullanıcılar kullanıcı = new Kullanıcılar();

            kullanıcı.isim= "Lorem";
            kullanıcı.soyisim="İpsum";
            kullanıcı.yas=99;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();

            kullanıcı.isim= "Dolor";
            kullanıcı.soyisim="Sir";
            kullanıcı.yas=89;

            kullanıcılistesi.Add(kullanıcı);
            kullanıcılistesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniliste = new List<Kullanıcılar>{};

            yeniliste.Add(new Kullanıcılar(){
                isim="Amet",
                soyisim="Lorem",
                yas=24
            });
            foreach (var n in kullanıcılistesi)
            {
                System.Console.WriteLine("Kullanıcı Adı: " + n.isim);
                System.Console.WriteLine("Kullanıcı Soyadı: " + n.soyisim);
                System.Console.WriteLine("Kullanıcı Yaşı: " + n.yas);
            }  


    }
    
public class Kullanıcılar{
            private string name;

            private string soyname;
            
            private int age;

            public string isim {get => name; set => name = value;}
            public string soyisim {get => soyname; set => soyname = value;}
            public int yas {get => age; set => age = value;}
        }
    }
}